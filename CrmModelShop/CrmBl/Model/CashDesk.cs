﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrmBl.Model
{
    public class CashDesk
    {
        CrmContext db = new CrmContext();
        public int Number { get; set; } // номер кассы
        public Seller Seller { get; set; } // продавец
        public Queue<Cart> Queue { get; set; } // очередь из телег
        public int MaxQueueLength { get; set; } // длинна очереди
        public int ExitCustomer { get; set; } // счетчик для ушедших людей
        //(если слишком большая очередь, уходит из магазина ничего не купив)
        public bool IsModel { get; set; } // будет ли выполняться сохранение в БД
        public int Count => Queue.Count;
        public event EventHandler<Check> CheckClosed;
        public CashDesk(int number, Seller seller)
        {
            Number = number;
            Seller = seller;
            Queue = new Queue<Cart>();
            IsModel = true;
        }
        public void Enqueue(Cart cart)
        {
            if(Queue.Count <= MaxQueueLength)
            {
                Queue.Enqueue(cart);
            }
            else
            {
                ExitCustomer++;
            }
        }
        public decimal Dequeue()
        {
            decimal sum = 0;
            if(Queue.Count == 0)
            {
                return 0;
            }
            var card = Queue.Dequeue();
            if(card != null)
            {
                var check = new Check()
                {
                    SellerId = Seller.SellerId,
                    Seller = Seller,
                    CustomerId = card.Customer.CustomerId,
                    Customer = card.Customer,
                    Created = DateTime.Now
                };
                if (!IsModel)
                {
                    db.Checks.Add(check);
                    db.SaveChanges();
                }
                else
                {
                    check.CheckId = 0;
                }
                var sells = new List<Sell>(); // вспомогательный список продаж
                foreach (Product product in card)
                {
                    if(product.Count > 0)
                    {
                        var sell = new Sell()
                        {
                            CheckId = check.CheckId,
                            Check = check,
                            ProductId = product.ProductId,
                            Product = product
                        };

                        sells.Add(sell);
                        if (!IsModel)
                        {
                            db.Sells.Add(sell);
                        }
                        product.Count--;
                        sum += product.Price;
                    }
                }
                check.Price = sum;
                if (!IsModel)
                {
                    db.SaveChanges();
                }
                CheckClosed?.Invoke(this, check);
            }
            return sum;
        }
        public override string ToString()
        {
            return $"Касса №{Number}";
        }
    }
}

using Fitness.BL.Controller;
using Fitness.BL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fitness.BLTests.Controller
{
    
    public class ExerciseController : ControllerBase
    {
        private readonly User user;
        private const string EXERCISES_FILE_NAME = "exercises.dat"; // тута остановился
        public List<Exercise> Exercises;
        public ExerciseController(User user)
        {
            this.user = user ?? throw new ArgumentNullException(nameof(user));
            Exercises = GetAllExercises();
        }

        private List<Exercise> GetAllExercises()
        {
            return Load<Exercise>(EXERCISES_FILE_NAME) ?? new List<Exercise>();
        }
    }
}

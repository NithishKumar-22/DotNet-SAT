using System;

namespace Task_1.Models{
    public interface IRespository{

        public void AddDetails(User user); 
        public IEnumerable<User> GetDetails();

    }
}
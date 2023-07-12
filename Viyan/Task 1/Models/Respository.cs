using System;
using System.Data.SqlClient;
using System.Dynamic;

namespace Task_1.Models{
    public class Respository : IRespository
    {
        public List<User> UserList;

        public Respository(){
            UserList = new List<User>();
        }
        public void AddDetails(User user)
        {
            dynamic Details = new ExpandoObject();
             UserList.Add(user);
        }

        public IEnumerable<User> GetDetails()
        {
          return UserList;
        }
    }

}
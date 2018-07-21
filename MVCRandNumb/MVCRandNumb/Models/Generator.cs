using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCRandNumb.Models
{
    public class Generator
    {
        private Random random = new Random();

        public int getNumber()
        {
            return random.Next(100);
        }
    }
}
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Backend_Logic
{
    // The Utils class is a static class with helper functions useful to database operations and data manipulation
    public static class Utils
    {
        //Hashing function to translate a string into it's SHA1 hash
        public static string GetSha1(String input)
        {
            using (SHA1Managed sha1 = new SHA1Managed())
            {
                var hash = sha1.ComputeHash(Encoding.UTF8.GetBytes(input));
                var result = new StringBuilder(hash.Length * 2);

                foreach (var by in hash)
                {
                    result.Append(by.ToString("x2"));
                }

                return result.ToString().ToUpper();
            }
        }
    }
}

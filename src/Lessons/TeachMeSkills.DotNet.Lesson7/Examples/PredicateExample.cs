﻿using System;

namespace TeachMeSkills.DotNet.Lesson7.Examples
{
    internal class PredicateExample
    {
        //delegate bool Compare(int val);
        private Predicate<int> predicate;

        private Predicate<string> comPred = delegate (string x) { return x.Length > 10; };
        //Predicate<string> comPred = x => x.Length > 10;

        public void Run()
        {
            //Compare compare = MyCommon.CompareWithValue;
            predicate = CommonMethods.CompareWithValue;
            var r1 = predicate(1);
            predicate += AnotherCompare;
            var r2 = predicate(2);
            predicate += AnotherCompare;

            var result = predicate(int.Parse(Console.ReadLine()));
            Console.WriteLine(result);

            Console.WriteLine(comPred("MySuperString"));

            Predicate<string> comPredSuper = x => x.Length > 11;
            Console.WriteLine(comPredSuper("MyString"));
        }

        private bool AnotherCompare(int val)
        {
            return val < 0;
        }
    }
}

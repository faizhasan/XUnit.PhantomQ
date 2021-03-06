﻿using Xunit;

namespace XUnit.PhantomQ
{
    public class QUnitTest
    {
        public QUnitTest(string name, bool success, string message, QUnitResultContext context)
        {
            Name = name;
            Success = success;
            Message = message;
            Context = context;
        }

        public string Name { get; private set; }
        public bool Success { get; private set; }
        public string Message { get; private set; }
        public QUnitResultContext Context { get; private set; }

        public void AssertSuccess()
        {
            Assert.True(Success, Message);
        }

        public override string ToString()
        {
            return Name;
        }
    }
}
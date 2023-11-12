﻿using System.Collections;

namespace Vsite.CSharp.DefiniranjeTipa.Testovi
{
    [TestClass]
    public abstract class ConsoleTest
    {
        protected class ConsoleTestWriter : StringWriter
        {
            public override void WriteLine(string? value)
            {
                output.Enqueue(value);
            }

            public override void WriteLine(int value)
            {
                output.Enqueue(value);
            }

            public override void WriteLine(double value)
            {
                output.Enqueue(value);
            }

            public override void WriteLine(object? value)
            {
                output.Enqueue(value);
            }

            public string? GetString()
            {
                return (string?)output.Dequeue();
            }

            public int GetInt()
            {
                return (int)output.Dequeue()!;
            }

            public double GetDouble()
            {
                return (double)output.Dequeue()!;
            }

            public object? GetObject()
            {
                return output.Dequeue();
            }

            public bool IsEmpty
            {
                get { return output.Count == 0; }
            }

            readonly Queue output = new Queue();
        }

        protected ConsoleTestWriter? cw = null;

        [TestInitialize()]
        public virtual void Initialize()
        {
            cw = new ConsoleTestWriter();
            Console.SetOut(cw);
        }

        [TestCleanup()]
        public virtual void Cleanup()
        {
            cw?.Dispose();
        }
    }
}

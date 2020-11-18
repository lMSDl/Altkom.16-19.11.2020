using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace WPCSharp.DesignPatterns.Behavioral.Memento
{
    public class Caretaker<T> where T : ICloneable, IRestorable<T>
    {
        private List<IMemento<T>> _mementos = new List<IMemento<T>>();
        private T _originator;

        public Caretaker(T originator)
        {
            _originator = originator;
        }

        public void Save()
        {
            Console.WriteLine("Zapisywanie");
            _mementos.Add(new Memento<T>((T)_originator.Clone()));
        }

        public void ChangeState(Func<T, bool> predicate)
        {
            var memento = _mementos.FirstOrDefault(x => predicate(x.State));
            if (memento == null)
                return;
            Save();
            _originator.Restore(memento.State);
        }

        public void Undo()
        {
            var memento = _mementos.LastOrDefault();
            if (memento == default)
                return;
            _mementos.Remove(memento);
            _originator.Restore(memento.State);
        }

        public override string ToString()
        {
            var builder = new StringBuilder();
            builder.AppendLine("Posiadam migawki:");
            _mementos.ForEach(x => builder.AppendLine(x.DateTime.ToString("U")));
            return builder.ToString();
        }
    }
}

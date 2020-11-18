using System;
using System.Collections.Generic;
using System.Linq;

namespace WPCSharp.DesignPatterns.Behavioral.Mediator
{
    public class Chat : IChatMediator
    {
        private ICollection<ChatMember> chatMembers = new List<ChatMember>();

        public void Join(ChatMember member)
        {
            chatMembers.Add(member);
        }

        public void Notify(string from, string message)
        {
            IEnumerable<ChatMember> query = chatMembers;
            if (chatMembers.Single(x => x.Nick == from) is ChatBot)
                query = query.Where(x => !(x is ChatBot));
            query = query.Where(x => x.Nick != from);
            query.ToList().ForEach(x => x.Receive(from, message, false));
        }

        public void Notify(string from, string to, string message)
        {
            chatMembers.SingleOrDefault(x => x.Nick == to)?.Receive(from, message, true);
        }

        public void Quit(ChatMember member)
        {
            chatMembers.Remove(member);
        }
    }
}

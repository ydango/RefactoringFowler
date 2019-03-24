// This is an open source non-commercial project. Dear PVS-Studio, please check it.

// PVS-Studio Static Code Analyzer for C, C++ and C#: http://www.viva64.com

using System.Collections.Generic;
using System.Collections.Immutable;

namespace Chapter1
{
    public enum PayType : byte
    {
        Tragedy,
        Comedy
    }

    public class Play
    {
        public readonly string Name;
        public readonly PayType PayType;

        public Play(string name, PayType payType)
        {
            Name = name;
            PayType = payType;
        }
    }

    public class Performance
    {
        public readonly int Audience;
        public readonly string PlayId;

        public Performance(string playId, int audience)
        {
            PlayId = playId;
            Audience = audience;
        }
    }

    public class Invoice
    {
        public readonly string Customer;
        public readonly ImmutableList<Performance> Performances;

        public Invoice(string customer, IEnumerable<Performance> performances)
        {
            Customer = customer;
            Performances = performances.ToImmutableList();
        }
    }

    public interface IVideoStore
    {
        string Statement(Invoice invoice, IReadOnlyDictionary<string, Play> plays);
    }
    public interface IHtmlVideoStore
    {
        string HtmlStatement(Invoice invoice, IReadOnlyDictionary<string, Play> plays);
    }

}
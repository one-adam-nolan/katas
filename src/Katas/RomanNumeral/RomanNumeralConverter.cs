using System;
using System.Collections.Generic;
using System.Linq;

namespace Katas.RomanNumeral
{
    public class RomanNumeralConverter
    {

        public static RomanNumeralConverter Create() => new RomanNumeralConverter();

        public decimal Convert(string symbols)
        {
            var numeralSet = PopulateSymbolsToList(BreakToChars(symbols));

            numeralSet.ApplyOperators();

            return numeralSet.Compute();
        }

        public RomanNumeralSet PopulateSymbolsToList(char[] symbols)
        {
            return RomanNumeralSet.FromSet(symbols.Select(GetNumeralFromValue));
        }

        private char[] BreakToChars(string symbols) => symbols.ToCharArray();

        private RomanNumeral GetNumeralFromValue(char symbol)
        {
            if (symbol == 'I')
                return new RomanNumeral(symbol.ToString(), 1);
            if (symbol == 'V')
                return new RomanNumeral(symbol.ToString(), 5);
            if (symbol == 'X')
                return new RomanNumeral(symbol.ToString(), 10);
            if (symbol == 'L')
                return new RomanNumeral(symbol.ToString(), 50);
            if (symbol == 'C')
                return new RomanNumeral(symbol.ToString(), 100);
            if (symbol == 'D')
                return new RomanNumeral(symbol.ToString(), 500);
            if (symbol == 'M')
                return new RomanNumeral(symbol.ToString(), 1000);
            else
                throw new Exception($"{symbol} is Not a Roman Numeral");

        }

    }

    public class RomanNumeral
    {
        public string Symbol { get; }

        public int Value => _value;

        private int _value;

        public RomanNumeral(string symbol, int value)
        {
            Symbol = symbol;
            _value = value;
        }

        public void FlipValue()
        {
            _value = _value * -1;

        }
    }

    public class RomanNumeralSet
    {

        private List<RomanNumeral> _symbols;

        public static RomanNumeralSet FromSet(IEnumerable<RomanNumeral> numerals) => new RomanNumeralSet(numerals);

        public RomanNumeralSet(IEnumerable<RomanNumeral> numerals)
        {
            _symbols = numerals?.ToList() ?? new List<RomanNumeral>();
        }

        public decimal Compute()
        {
            return _symbols.Select(n => n.Value).Sum();
        }

        public void ApplyOperators()
        {
            for (int i = 0; i < _symbols.Count; ++i)
            {
                if (i != _symbols.Count - 1)
                {
                    var currentSymbol = _symbols[i];
                    if (_symbols.Any(x => IsLessThanTarget(currentSymbol.Value, x.Value) && _symbols.IndexOf(x) > _symbols.IndexOf(currentSymbol)))
                        currentSymbol.FlipValue();
                }
            }
        }

        private bool IsLessThanTarget(int current, int target) => current < target;

    }
}

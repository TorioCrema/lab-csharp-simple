namespace Properties
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// A factory class for building <see cref="ISet{T}">decks</see> of <see cref="Card"/>s.
    /// </summary>
    public class DeckFactory
    {
        private string[] _seeds;

        private string[] _names;

        // TODO improve
        public IList<string> Seeds
        {
            get => this._seeds.ToList();
            set => this._seeds = value.ToArray();
        }

        // TODO improve
        public IList<string> Names
        {
            get => this._names.ToList();
            set => this._names = value.ToArray();
        }

        // TODO improve
        public int GetDeckSize() => this.Names.Count * this.Seeds.Count;

        /// TODO improve
        public ISet<Card> Deck
        {
            get
            {
                if (this.Names == null || this.Seeds == null)
                {
                    throw new InvalidOperationException();
                }

                return new HashSet<Card>(Enumerable
                    .Range(0, this.Names.Count)
                    .SelectMany(i => Enumerable
                        .Repeat(i, this.Seeds.Count)
                        .Zip(
                            Enumerable.Range(0, this.Seeds.Count),
                            (n, s) => Tuple.Create(this.Names[n], this.Seeds[s], n)))
                    .Select(tuple => new Card(tuple))
                    .ToList());
            }
        }
    }
}

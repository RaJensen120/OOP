using System.Runtime.InteropServices.ComTypes;

namespace L6
{
    public class Pair<Type1, Type2>
    {
        public Type1 Fst { get; private set; }
        public Type2 Snd { get; private set; }
        
        public Pair(Type1 fst, Type2 snd)
        {
            Fst = fst;
            Snd = snd;
        }

        public Pair<Type2, Type1> Swap<Type1, Type2>(Pair<Type1, Type2> pair)
        {
            Pair<Type2, Type1> swap = new Pair<Type2, Type1>(pair.Snd, pair.Fst);
            //swap.Fst = pair.Snd;
            
            return swap;
        }
    }
}
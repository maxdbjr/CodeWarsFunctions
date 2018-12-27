using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWarsFunctions
{
    class Program
    {
        static void Main(string[] args)
        {
//            int iResult = 0;
//            long lResult = 0;

            int[] intList = MoveZeroes(new int[] {1, 2, 0, 1, 0, 1, 0, 3, 0, 1}); // new int[] {1, 2, 1, 1, 3, 1, 0, 0, 0, 0}

            bool passFail = isMerge("codewars", "code", "wars"); // True
            passFail = isMerge("codewars", "cdwr", "oeas"); // True
            passFail = isMerge("codewars", "cod", "wars"); // False
            passFail = isMerge("Bananas from Bahamas", "Bahas", "Bananas from am"); // True
            passFail = isMerge("Can we merge it? Yes, we can!", "n ee tYw n!", "Cawe mrgi? es, eca"); // True
            passFail = isMerge("Bananas from Bahamas", "Yf`f&omaa`'", "caPF/GBhs"); // False
            passFail = isMerge("Bananas from Bahamas", "Uaasn (8as", "@RIO->mP#a"); // False
            passFail = isMerge("codewars", "cod", "wasr"); // False

            string newOrder = orderWeight("103 123 4444 99 2000"); // "2000 103 123 4444 99"
            newOrder = orderWeight("2000 10003 1234000 44444444 9999 11 11 22 123"); // "11 11 2000 10003 22 123 1234000 44444444 9999"

            List<int> ts = new List<int> { 50, 55, 56, 57, 58 };
            int? n = chooseBestSum(163, 3, ts); // 163
            ts = new List<int> { 50 };
            n = chooseBestSum(163, 3, ts); // null
            ts = new List<int> { 91, 74, 73, 85, 73, 81, 87 };
            n = chooseBestSum(230, 3, ts); // 228

            char alphaChar = FindMissingLetter(new [] { 'a','b','c','d','f' }); // e
            alphaChar = FindMissingLetter(new [] { 'O','Q','R','S' }); // P

            List<string> anagrams = Anagrams("a", new List<string> { "a", "b", "c", "d" }); // { "a" }
            anagrams = Anagrams("racer", new List<string> { "carer", "arcre", "carre", "racrs", "racers", "arceer", "raccer", "carrer", "cerarr" }); //{ "carer", "arcre", "carre" }
            anagrams = Anagrams("abba", new List<string> { "aabb", "abcd", "bbaa", "dada" }); // {"aabb", "bbaa" }
            anagrams = Anagrams("racer", new List<string> { "crazer", "carer", "racar", "caers", "racer" }); // { "carer", "racer" }
            anagrams = Anagrams("laser", new List<string> { "lazing", "lazy", "lacer" }); // {}

            string works = Tickets(new int[] { 25, 25, 50, 50 });
            works = Tickets(new int[] { 25, 100 });
            works = Tickets(new int[] { 25, 25, 25, 25, 50, 100, 50 });

            string consec = LongestConsec(new String[] { "zone", "abigail", "theta", "form", "libe", "zas", "theta", "abigail" }, 2); // "abigailtheta"
            consec = LongestConsec(new String[] { "ejjjjmmtthh", "zxxuueeg", "aanlljrrrxx", "dqqqaaabbb", "oocccffuucccjjjkkkjyyyeehh" }, 1); // "oocccffuucccjjjkkkjyyyeehh"
            consec = LongestConsec(new String[] { }, 3); // ""
            consec = LongestConsec(new String[] { "itvayloxrp", "wkppqsztdkmvcuwvereiupccauycnjutlv", "vweqilsfytihvrzlaodfixoyxvyuyvgpck" }, 2); // "wkppqsztdkmvcuwvereiupccauycnjutlvvweqilsfytihvrzlaodfixoyxvyuyvgpck"
            consec = LongestConsec(new String[] { "wlwsasphmxx", "owiaxujylentrklctozmymu", "wpgozvxxiu" }, 2); // "wlwsasphmxxowiaxujylentrklctozmymu"
            consec = LongestConsec(new String[] { "zone", "abigail", "theta", "form", "libe", "zas" }, -2); // ""
            consec = LongestConsec(new String[] { "it", "wkppv", "ixoyx", "3452", "zzzzzzzzzzzz" }, 3); // "ixoyx3452zzzzzzzzzzzz"
            consec = LongestConsec(new String[] { "it", "wkppv", "ixoyx", "3452", "zzzzzzzzzzzz" }, 15); // ""
            consec = LongestConsec(new String[] { "it", "wkppv", "ixoyx", "3452", "zzzzzzzzzzzz" }, 0); // ""

            long sqr = findNextSquare(121);
            sqr = findNextSquare(625);
            sqr = findNextSquare(114);
            sqr = findNextSquare(155);
            sqr = findNextSquare(319225);
            sqr = findNextSquare(15241383936);

            string[] names = { "Ryan", "Kieran", "Mark", "Jimmy" };
            IEnumerable<string> friends = FriendOrFoe(names);

            string masked = Maskify("4556364607935616");
            masked = Maskify("1");
            masked = Maskify("11111");

            string dna = MakeComplement("AAAA");
            dna = MakeComplement("ATTGC");
            dna = MakeComplement("GTAT");

            Persistence(39);
            Persistence(4);
            Persistence(25);
            Persistence(999);

            {
                var list = new List<object>() { 1, 2, "a", "b" };
                var expected = new List<int>() { 1, 2 };
                var actual = GetIntegersFromList(list);
            }
            {
                var list = new List<object>() { 1, "a", "b", 0, 15 };
                var expected = new List<int>() { 1, 0, 15 };
                var actual = GetIntegersFromList(list);
            }
            {
                var list = new List<object>() { 1, 2, "aasf", "1", "123", 123 };
                var expected = new List<int>() { 1, 2, 123 };
                var actual = GetIntegersFromList(list);
            }
            {
                var list = new List<object>() { "sadfgas", "asdf" };
                var expected = new List<int>() { };
                var actual = GetIntegersFromList(list);
            }
        }

        public static int[] MoveZeroes(int[] iList)
        {
            List<int> intList = new List<int> { };

            // int zCnt = iList.Where(x => x != 0).Count();
            intList = iList.Where(x => x != 0).ToList();
            int zCnt = iList.Count() - intList.Count();
            for (int i = 0; i < zCnt; i++)
                intList.Add(0);

            return (intList.ToArray());
        }

        public static bool isMerge(string s, string part1, string part2)
        {
            if (s.Length != (part1.Length + part2.Length))
                return (false);

            Console.WriteLine("s: {0}\npart1: {1}\npart2: {2}", s, part1, part2);

            string debug = "";

            int x = 0;
            int y = 0;
            for (int i = 0; i < s.Length; i++)
            {
                string sChar = s[i].ToString();

                int charCnt1 = getConsecCount(s, i, part1, x);
                int charCnt2 = getConsecCount(s, i, part2, y);

                if ((charCnt1 > 0) && (charCnt1 >= charCnt2))
                {
                    if ((x < part1.Length) && (sChar == part1[x].ToString()))
                    {
                        string p1Char = part1[x].ToString();
                        debug += p1Char;
                        x++;
                    }
                }
                else
                {
                    if ((charCnt2 > 0) && (charCnt1 < charCnt2))
                    {
                        if ((y < part2.Length) && (sChar == part2[y].ToString()))
                        {
                            string p2Char = part2[y].ToString();
                            debug += p2Char;
                            y++;
                        }
                    }
                    else
                        return (false);
                }
            }
            return (true);
        }

        public static int getConsecCount(string s, int sI, string part, int pI)
        {
            int count = 0;
            int x = pI;

            for (int i = sI; i < s.Length; i++)
            {
                if ((x < part.Length) && (s[i].ToString() == part[x].ToString()))
                {
                    count++;
                    x++;
                }
                else
                    break;
            }
            return (count);
        }

        public static string orderWeight(string strng)
        {
            string newOrder = "";
            if (strng.Trim().Length <= 0)
                return (newOrder);

            string[] weights = strng.Trim().Split(' ');
            int maxL = weights.Max(x => x.Length);

            List<string> sortedW = new List<string>();

            for (int i = 0; i < weights.Count(); i++)
            {
                string weight = weights[i].Trim();
                int sum = 0;
                for (int j = 0; j < weight.Length; j++)
                {
                    string num = weight[j].ToString();
                    sum += Convert.ToInt32(num);
                }

                sortedW.Add(sum.ToString().PadLeft(maxL, '0') + "#" + weight);
            }
            IEnumerable<string> sorted = sortedW.OrderBy(x => x).ToArray();
            foreach (string item in sorted)
            {
                string[] tmp = item.Split('#');
                newOrder += tmp[1] + " ";
            }
            return (newOrder.Trim());
        }

        public static int? chooseBestSum(int t, int k, List<int> ls)
        {
            // t = max distance, k = # of towns - Best travel
            if (ls.Count < k)
                return (null);

            int mileage = 0;

            for (int i = 0; i < (ls.Count - k); i++)
            {
                int tmpMil = 0;
                int townCnt = 0;
                int indx = i;
                while (indx < (ls.Count-k))
                {
                    tmpMil += ls[indx+townCnt];
                    townCnt++;
                    if (townCnt >= k)
                    {
                        if ((tmpMil > mileage) && (tmpMil < t))
                            mileage = tmpMil;
                        indx += townCnt;
                        townCnt = 0;
                    }
                }
            }
            return (mileage);
        }

        public static char FindMissingLetter(char[] array)
        {
            string strAlphabet = "abcdefghijklmnopqrstuvwxyz";
            char[] alphabet = strAlphabet.ToCharArray();
            if (char.IsUpper(array[0]))
                alphabet = strAlphabet.ToUpper().ToCharArray();

            char missingChar = ' ';
            int iPos = -1;
            for (int i = 0; i < array.Length; i++)
            {
                if (i <= 0)
                    iPos = Array.IndexOf(alphabet, array[i]);

                if (array[i] != alphabet[iPos + i])
                {
                    missingChar = alphabet[iPos+i];
                    break;
                }
            }
            return (missingChar);
        }

        public static List<string> Anagrams(string word, List<string> words)
        {
            List<string> match = new List<string> { };

            foreach (string lword in words)
            {
                if (word.Length != lword.Length)
                    continue;

                char[] chAr;
                string tmpW = word;
                string tmpLW = lword;
                for (int i = 0; i < lword.Length; i++)
                {
                    string wChar = lword[i].ToString();

                    int iPos = tmpW.IndexOf(wChar);
                    if (iPos >= 0)
                    {
                        chAr = tmpW.ToCharArray();
                        chAr[iPos] = ' ';
                        tmpW = new string(chAr);
                    }
                    iPos = tmpLW.IndexOf(wChar);
                    chAr = tmpLW.ToCharArray();
                    chAr[iPos] = ' ';
                    tmpLW = new string(chAr);
                }
                if ((tmpW.Trim().Length <= 0) && (tmpLW.Trim().Length <= 0))
                    match.Add(lword);
            }

            return (match);
        }

        public static string Tickets(int[] peopleInLine)
        {
            string canChg = "YES";
            if (peopleInLine.Length <= 0)
                canChg = "NO";
            int twFive = 0;
            int fifty = 0;

            for (int i = 0; i < peopleInLine.Length; i++)
            {
                if (peopleInLine[i] == 25)
                    twFive++;
                if (peopleInLine[i] == 50)
                {
                    fifty++;
                    twFive--;
                }
                if (peopleInLine[i] == 100)
                {
                    if ((fifty >= 1) && (twFive >= 1))
                    {
                        twFive--;
                        fifty--;
                    }
                    else
                    {
                        twFive -= 3;
                    }
                }
                if (twFive < 0)
                {
                    canChg = "NO";
                    break;
                }
            }

            return (canChg);
        }

        public static string LongestConsec(string[] strarr, int k)
        {
            string kconsec = "";
            if ((strarr.Length <= 0) || (k > strarr.Length) || (k <= 0))
                return (kconsec);

            for (int i = 0; i < k; i++)
                kconsec += strarr[i];

            for (int i = 1; i < strarr.Length; i++)
            {
                string kconsec2 = "";
                if ((i + k) <= strarr.Length)
                {
                    for (int j = i; j < i + k; j++)
                        kconsec2 += strarr[j];

                    if (kconsec2.Length > kconsec.Length)
                        kconsec = kconsec2;
                }
            }

            return (kconsec);
        }

        public static long findNextSquare(long num)
        {
            long nextNum = -1;
            double sqr = Math.Sqrt(Convert.ToDouble(num));
            double rnd = Math.Round(sqr, 0);
            if ((sqr - rnd) == 0)
                nextNum = (long)(++sqr * sqr);

            return (nextNum);
        }

        public static IEnumerable<string> FriendOrFoe(string[] names)
        {
            IEnumerable<string> friends = names.Where(n => n.Length <= 4).ToArray();
            return (friends);
        }

        public static string Maskify(string cc)
        {
            string mask = "";

            for (int i = 0; (i < 4) && (i < cc.Length); i++)
            {
                int indx = (cc.Length - 1) - i;
                mask = cc[indx].ToString() + mask;
            }
            if (cc.Length > 4)
                mask = mask.PadLeft(cc.Length, '#');

            return (mask);
        }

        public static string MakeComplement(string dna)
        {
            string comp = "";
            for (int i = 0; i < dna.Length; i++)
            {
                string sym = dna[i].ToString().ToUpper();
                switch (sym)
                {
                    case "A":
                        comp += "T";
                        break;
                    case "T":
                        comp += "A";
                        break;
                    case "C":
                        comp += "G";
                        break;
                    case "G":
                        comp += "C";
                        break;
                }
            }
            return (comp);
        }

        public static int Persistence(long n)
        {
            int perCnt = 0;
            string num = n.ToString();
            if (num.Length <= 1)
                return (0);

            int prod = 1;
            for (int i = 0; i < num.Length; i++)
                prod = prod * int.Parse(num[i].ToString());

            if (num.Length > 1)
                perCnt = perCnt + Persistence(prod) + 1;
            return (perCnt);
        }

        public static bool IsValidWalk(string[] walk)
        {
            List<string> listWalk = walk.ToList();

            bool bValid = true;
            if (walk.Length != 10)
                return (bValid);

            int wN = walk.Where(n => n.ToUpper().Equals("N")).Count();
            int wS = walk.Where(s => s.ToUpper().Equals("S")).Count();
            int wW = walk.Where(w => w.ToUpper().Equals("W")).Count();
            int wE = walk.Where(e => e.ToUpper().Equals("E")).Count();
            if ((wN != wS) || (wW != wE))
                return (bValid);

            return (bValid);
        }

        public static IEnumerable<int> GetIntegersFromList(List<object> listOfItems)
        {
            List<int> listOfInts = new List<int>();

            for (int i = 0; i < listOfItems.Count; i++)
            {
                if (listOfItems[i] is int)
                    listOfInts.Add((int)listOfItems[i]);
            }
            return (listOfInts);

            //            return listOfItems.OfType<int>();
            //            return listOfItems.Where(x=> x is int).Select(x => (int)x);
        }
    }
}

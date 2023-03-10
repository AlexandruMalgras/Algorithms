// See https://aka.ms/new-console-template for more information

using ConsoleApp1.Algorithms;
using ConsoleApp1.Algorithms.Implementation;
using ConsoleApp1.Algorithms.Search;
using ConsoleApp1.Algorithms.Sorting;
using ConsoleApp1.Algorithms.Strings;
using System;
using System.Data.SqlTypes;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Numerics;
using System.Security.Cryptography.X509Certificates;

CaesarCipher.caesarCipher("middle-Outz", 2);

static ListNode AddTwoNumbers(ListNode l1, ListNode l2)
{
    int[] values = new int[] { 2, 4, 3 };

    l1 = new ListNode();

    foreach (int value in values)
    {
        var current = new ListNode(value);
        current.next = l1;
        l1 = current;
    }

    int sum = 0;

    while (l1 != null)
    {
        sum += l1.val;

        l1 = l1.next;
    }

    return null;
}

static int flatlandSpaceStations(int n, int[] c)
{
    Array.Sort(c);

    int maxDistance = 0;

    int closestLeft = -1;
    int closestsRight = -1;

    int distanceLeft = 0;
    int distanceRight = 0;

    for (int i = 0; i < n; i++)
    {
        if (c.Contains(i))
        {
            closestLeft = i;
            continue;
        }

        if (closestsRight < i)
        {
            closestsRight = c.Where(x => x > i).OrderBy(x => Math.Abs(x - i)).FirstOrDefault(-1);
        }

        if (closestLeft != -1 && closestsRight != -1)
        {
            distanceLeft = i - closestLeft;
            distanceRight = closestsRight - i;

            if (distanceLeft <= distanceRight)
            {
                if (distanceLeft > maxDistance)
                {
                    maxDistance = distanceLeft;
                }
            }
            else
            {
                if (distanceRight > maxDistance)
                {
                    maxDistance = distanceRight;
                }
            }
        }
        else
        {
            if (closestLeft != -1)
            {
                distanceLeft = i - closestLeft;

                if (distanceLeft > maxDistance)
                {
                    maxDistance = distanceLeft;
                }
            }

            if (closestsRight != -1)
            {
                distanceRight = closestsRight - i;

                if (distanceRight > maxDistance)
                {
                    maxDistance = distanceRight;
                }
            }
        }
    }

    return maxDistance;
}

static int workbook(int n, int k, List<int> arr)
{
    int currentPage = 0;
    int count = 0;

    for (int i = 0; i < n; i++)
    {
        currentPage++;

        for (int j = 1; j <= arr[i]; j++)
        {
            if (j == currentPage)
            {
                count++;
            }

            if (j % k == 0 && j != arr[i])
            {
                currentPage++;
            }
        }
    }

    return count;
}

static List<int> serviceLane(int n, List<int> width,  List<List<int>> cases)
{
    List<int> temporary = new List<int>();

    int minValue = int.MaxValue;

    for (int i = 0; i < cases.Count; i++)
    {
        minValue = int.MaxValue;

        for (int j = cases[i][0]; j <= cases[i][1]; j++)
        {
            if (width[j] < minValue)
            {
                minValue = width[j];
            }
        }

        temporary.Add(minValue);
    }

    return temporary;
}

static int chocolateFeast(int n, int c, int m)
{
    int wrappers = (int)Math.Floor((decimal)n / c);

    int finalResult = wrappers;
    int calculationResult = 0;

    while (wrappers >= m)
    {
        calculationResult = (int)Math.Floor((decimal)wrappers / m);

        finalResult += calculationResult;
        wrappers = calculationResult + wrappers % m;
    }

    return finalResult;
}

static int beautifulTriplets(int d, List<int> arr)
{
    int count = 0;

    int indexOfFirst = 0;
    int indexOfSecond = 0;

    int firstNumber = 0;
    int secondNumber = 0;

    for (int i = 0; i < arr.Count - 2; i++)
    { 
        firstNumber = arr[i] + d;

        if (!arr.Contains(firstNumber)) continue;

        indexOfFirst = arr.IndexOf(firstNumber);

        while(true)
        {
            if (arr[indexOfFirst] != firstNumber) break;

            secondNumber = arr[indexOfFirst] + d;

            if (!arr.Contains(secondNumber)) break;

            indexOfSecond = arr.IndexOf(secondNumber);

            while (true)
            {
                if (indexOfSecond > arr.Count - 1) break;
                if (arr[indexOfSecond] != secondNumber) break;

                count++;
                indexOfSecond++;
            }

            indexOfFirst++;
        }
    }

    return count;
}

static void kaprekarNumbers(int p, int q)
{
    string left = string.Empty;
    string right = string.Empty;

    int leftLength = 0;
    int rightLength = 0;

    string convertedP = "";

    long square = 0;

    List<int> kaprekarNumbers = new List<int>();

    int result = 0;

    for (; p <= q; p++)
    {
        square = (long)Math.Pow((double)p, 2.0);
        convertedP = square.ToString();

        leftLength = (int)Math.Floor(convertedP.Length / 2.0);
        rightLength = convertedP.Length - leftLength;

        left = convertedP.Substring(0, leftLength);
        right = convertedP.Substring(leftLength, rightLength);

        if (left == "") left = "0";
        if (int.Parse(right) == 0) continue;

        result = int.Parse(left) + int.Parse(right);

        if (result == p) kaprekarNumbers.Add(result);
    }

    if (kaprekarNumbers.Count == 0)
    {
        Console.WriteLine("INVALID RANGE");
    }

    string output = "";

    foreach (int i in kaprekarNumbers)
    {
        output += i + " ";
    }

    Console.WriteLine(output);
}

static string timeInWords(int h, int m)
{
    string[] hours = new string[] { "one", "two", "three", "four", "five", "six", "seven", "eight", "nine", "ten", "eleven", "twelve" };

    string[] minutes = new string[] { "one", "two", "three", "four", "five", "six", "seven", "eight", "nine", "ten", "eleven", "twelve", "thirteen", "fourteen", "quarter",
    "sixteen", "seventeen", "eighteen", "nineteen", "twenty", "twenty one", "twenty two", "twenty three", "twenty four", "twenty five", "twenty six", "twenty seven",
    "twenty eight", "twenty nine" };

    if (m == 00)
    {
        return hours[h - 1] + " o' clock";
    }

    if (m < 30)
    {
        if (m == 15)
        {
            return minutes[m - 1] + " past " + hours[h - 1];
        }

        if (m == 1)
        {
            return minutes[m - 1] + " minute past " + hours[h - 1];
        }

        return minutes[m - 1] + " minutes past " + hours[h - 1];
    }
    else if (m == 30)
    {
        return "half past " + hours[h - 1];
    }
    else
    {
        if (m == 45)
        {
            return minutes[59 - m] + " to " + hours[h % hours.Length];
        }

        return minutes[(60 - m - 1)] + " minutes to " + hours[h % hours.Length];
    }
}

static long taumBday(int b, int w, int bc, int wc, int z)
{
    int blackToWhiteConversion = bc + z;
    int whiteToBlackConversion = wc + z;

    if (blackToWhiteConversion < wc)
    {
        wc = blackToWhiteConversion;
    }

    if (whiteToBlackConversion < bc) 
    {
        bc = whiteToBlackConversion;
    }

    long costOfBlack = (long)b * (long)bc;
    long costOfWhite = (long)w * (long)wc;

    long result = costOfBlack + costOfWhite;

    return result;
}


static string biggerIsGreater(string w)
{
    bool hasChanged = false;

    List<char> remaining = new List<char>();
    char toBeChanged = '#';
    char newChar = '#';

    for (int i = w.Length - 2; i >= 0; i--)
    {
        remaining = w.Skip(i + 1).ToList();

        toBeChanged = w[i];

        char nextChar = remaining.OrderBy(c => c).FirstOrDefault(c => c > toBeChanged);

        if (nextChar != default(char))
        {
            remaining.Remove(nextChar);
            remaining.Add(toBeChanged);

            remaining.Sort();

            w = w.Substring(0, i) + nextChar + w.Substring(i + 1);
            w = w.Remove(i + 1, (w.Length) - (i + 1));

            foreach (char c in remaining)
            {
                w += c;
            }

            hasChanged = true;
            break;
        }
    }

    if (hasChanged)
    {
        return w;
    }

    return "no answer";
}

static List<int> acmTeam2(List<string> topic)
{
    int teams = topic.Count;
    int maxSkills = 0;
    int numMaxSkillsTeams = 0;

    for (int i = 0; i < teams - 1; i++)
    {
        for (int j = i + 1; j < teams; j++)
        {
            int skills = 0;

            for (int k = 0; k < topic[i].Length; k++)
            {
                if (topic[i][k] == '1' || topic[j][k] == '1')
                {
                    skills++;
                }
            }

            if (skills > maxSkills)
            {
                maxSkills = skills;
                numMaxSkillsTeams = 1;
            }
            else if (skills == maxSkills)
            {
                numMaxSkillsTeams++;
            }
        }
    }

    return new List<int> { (int)maxSkills, numMaxSkillsTeams };
}

static List<int> acmTeam(List<string> topic)
{
    List<int> temporary = new List<int>();

    string topics = "";
    int countOne = 0;

    for (int i = 0; i < topic.Count - 1; i++)
    {
        for ( int j = i + 1; j < topic.Count; j++)
        {
            topics = topic[i];

            for (int x = 0; x < topic[j].Length; x++)
            {
                if (topic[j][x] == '1')
                {
                    topics = topics.Substring(0, x) + "1" + topics.Substring(x + 1);
                }
            }

            countOne = topics.Count(x => x == '1');

            temporary.Add(countOne);
        }
    }

    int maxValue = temporary.Max();
    int maxValueCount = temporary.Count(x => x == maxValue);

    temporary.Clear();

    temporary.Add(maxValue);
    temporary.Add(maxValueCount);

    return temporary;
}

static int equalizeArray(List<int> arr)
{
    int count = 0;

    Dictionary<int, int> integerCount = new Dictionary<int, int>();

    for (int i = 0; i < arr.Count; i++)
    {
        if (!integerCount.Keys.Contains(arr[i]))
        {
            integerCount.Add(arr[i], 1);
        }
        else
        {
            integerCount[arr[i]]++;
        }
    }

    int often = integerCount.FirstOrDefault(a => a.Value == integerCount.Values.Max()).Key;

    for (int i = 0; i < arr.Count; i++)
    {
        if (arr[i] != often)
        {
            count++;
        }
    }

    return count;
}

static List<int> cutTheSticks(List<int> arr)
{
    List<int> temporary = new List<int>();

    int smallest = 0;

    while(arr.Count > 0)
    {
        temporary.Add(arr.Count);

        smallest = arr.Min();

        for (int i = 0; i < arr.Count; i++)
        {
            arr[i] -= smallest;

            if (arr[i] == 0)
            {
                arr.Remove(0);
                i--;
            }
        }
    }

    return temporary;
}

static int libraryFine(int d1, int m1, int y1, int d2, int m2, int y2)
{
    if (y1 < y2) return 0;
    if (y1 == y2 && m1 < m2) return 0;

    if (y1 == y2 && m1 == m2)
    {
        if (d1 <= d2)
        {
            return 0;
        }
        else
        {
            return (d1 - d2) * 15;
        }
    }
    else if (m1 > m2 && y1 == y2)
    {
        return (m1 - m2) * 500;
    }
    else
    {
        return 10000;
    }
}

static int jumpingOnClouds2(List<int> c)
{
    int jumps = 0;

    for (int i = 0; i < c.Count - 1;)
    {
        try
        {
            if (c[i + 2] == 0)
            {
                i += 2;
                jumps++;
            }
            else
            {
                i++;
                jumps++;
            }
        }
        catch
        {
            jumps++;
            break;
        }
    }

    return jumps;
}

static List<int> permutationEquation(List<int> p)
{
    List<int> temporary = new List<int>();

    int index = 0;

    for (int i = 1; i <= p.Count; i++)
    {
        index = p.IndexOf(i) + 1;

        temporary.Add(p.IndexOf(index) + 1);    
    }

    return temporary;
}

static int findDigits(int n)
{
    string digits = n.ToString();
    int count = 0;

    foreach (char c in digits)
    {
        int toDivide = int.Parse(c.ToString());

        try
        {
            if (n % toDivide == 0)
            {
                count++;
            }
        }
        catch (DivideByZeroException)
        {
            continue;
        }
    }

    return count;
}

static int jumpingOnClouds(int[] c, int k)
{
    int energy = 100;

    int index = k;
    int count = 0;

    while (index != 0 && energy >= 0)
    {
        index = (count + k) % c.Length;

        energy--;

        if (c[index] == 1)
        {
            energy -= 2;
        }

        count += k;
    }

    return energy;
}

static List<int> icecreamParlor(int m, List<int> arr)
{
    List<int> temporary = new List<int>();

    List<int> fakeArr = new List<int>();

    int toFind = 0;

    for (int i = 0; i < arr.Count; i++)
    {
        fakeArr = arr.Skip(i + 1).ToList();

        toFind = m - arr[i];

        if (fakeArr.Contains(toFind))
        {
            temporary.Add(i + 1);
            temporary.Add(fakeArr.IndexOf(toFind) + i + 2);
            break;
        }
    }

    return temporary;
}

static int saveThePrisoner(int n, int m, int s)
{
    m += s - 1;

    if (m <= n)
    {
        return m;
    }

    if (m % n == 0)
    {
        return n;
    }

    return m % n;
}

static string appendAndDelete(string s, string t, int k)
{
    int i = 0;
    while (i < s.Length && i < t.Length && s[i] == t[i])
    {
        i++;
    }
    int minOperations = s.Length + t.Length - 2 * i;
    if (k >= minOperations && (k - minOperations) % 2 == 0 || k >= s.Length + t.Length)
    {
        return "Yes";
    }

     return "No";
}

static int squares(int a, int b)
{
    int count = 0;

    int startSqrt = (int)Math.Ceiling(Math.Sqrt(a));
    int endSqrt = (int)Math.Floor(Math.Sqrt(b));

    count = endSqrt - startSqrt + 1;

    return count;
}

static string twoStrings(string s1, string s2)
{
    char[] uniqueCharacters = s1.Distinct().ToArray();

    foreach (char c in uniqueCharacters)
    {
        if (s2.Contains(c))
        {
            return "YES";
        }
    }

    return "NO";
}

static void matrixRotation(List<List<int>> matrix, int r)
{
    int[] result = default;
    int layers = (int)Math.Ceiling((decimal)(Math.Min(matrix.Count, matrix[0].Count) / 2));

    int index = 0;

    for (int i = 0; i < layers; i++)
    {
        int[] temporary = new int[0];

        for (int x = i; x < matrix[0].Count - 1 - i; x++)
        {
            Array.Resize(ref temporary, temporary.Length + 1);
            temporary[temporary.Length - 1] = matrix[i][x];
        }

        for (int x = i; x < matrix.Count - 1 - i; x++)
        {
            Array.Resize(ref temporary, temporary.Length + 1);
            temporary[temporary.Length - 1] = matrix[x][matrix[i].Count - 1 - i];
        }

        for (int x = matrix[matrix.Count - 1].Count - 1 - i; x > i; x--)
        {
            Array.Resize(ref temporary, temporary.Length + 1);
            temporary[temporary.Length - 1] = matrix[matrix.Count - 1 - i][x];
        }

        for (int x = matrix.Count - 1 - i; x > i; x--)
        {
            Array.Resize(ref temporary, temporary.Length + 1);
            temporary[temporary.Length - 1] = matrix[x][i];
        }

        result = new int[temporary.Length];
        int distance = r % result.Length;

        for (int x = 0; x < temporary.Length; x++)
        {
            index = (x + temporary.Length - distance) % temporary.Length;

            result[index] = temporary[x];
        }

        int length = 0;

        for (int x = i; x < matrix[0].Count - 1 - i; x++)
        {
            matrix[i][x] = result[length];
            length++;
        }

        for (int x = i; x < matrix.Count - 1 - i; x++)
        {
            matrix[x][matrix[i].Count - 1 - i] = result[length];
            length++;
        }

        for (int x = matrix[matrix.Count - 1].Count - 1 - i; x > i; x--)
        {
            matrix[matrix.Count - 1 - i][x] = result[length];
            length++;
        }

        for (int x = matrix.Count - 1 - i; x > i; x--)
        {
            matrix[x][i] = result[length];
            length++;
        }
    }

    foreach (List<int> list in matrix)
    {
        string experiment = "";

        foreach (int i in list)
        {
            experiment += i + " ";
        }

        Console.WriteLine(experiment);
    }
}

static List<int> circularArrayRotation(List<int> a, int k, List<int> queries)
{
    int[] result = new int[a.Count];

    int index = 0;

    for (int i = 0; i < a.Count; i++)
    {
        index = (i + k) % a.Count;
        
        result[index] = a[i];
    }

    for (int i = 0; i < queries.Count; i++)
    {
        Array.Resize(ref result, result.Length + 1);
        result[i + a.Count] = result[queries[i]];
    }

    return result.Skip(a.Count).ToList();
}

static int surfaceArea(List<List<int>> A)
{
    int surfaces = 0;
    int cubeSurfaces = 0;

    int topNeighbour = 0;
    int bottomNeighbour = 0;
    int leftNeighbour = 0;
    int rightNeighbour = 0;
    int current = 0;

    for (int i = 0; i < A.Count; i++)
    {
        for (int x = 0; x < A[i].Count; x++)
        {
            current = A[i][x];

            while (current > 0)
            {
                cubeSurfaces = 6;

                if (i > 0)
                {
                    topNeighbour = A[i - 1][x];

                    if (topNeighbour >= current)
                    {
                        cubeSurfaces--;
                        topNeighbour--;
                    }
                }

                if (i < A.Count - 1)
                {
                    bottomNeighbour = A[i + 1][x];

                    if (bottomNeighbour >= current)
                    {
                        cubeSurfaces--;
                        bottomNeighbour--;
                    }
                }

                if (x > 0)
                {
                    leftNeighbour = A[i][x - 1];

                    if (leftNeighbour >= current)
                    {
                        cubeSurfaces--;
                        leftNeighbour--;
                    }
                }

                if (x < A[i].Count - 1)
                {
                    rightNeighbour = A[i][x + 1];

                    if (rightNeighbour >= current)
                    {
                        cubeSurfaces--;
                        rightNeighbour--;
                    }
                }

                if (current > 1)
                {
                    cubeSurfaces--;
                }

                if (current < A[i][x])
                {
                    cubeSurfaces--;
                }

                surfaces += cubeSurfaces;
                current--;
            }

        }
    }

    return surfaces;
}

static int utopianTree(int n)
{
    int treeHeight = 1;

    for (int i = 0; i < n; i++)
    {
        if (i % 2 == 0)
        {
            treeHeight *= 2;
        }
        else
        {
            treeHeight++;
        }
    }

    return treeHeight;
}


static void Loop(int a, int b, int n)
{
    int result = a;

    for (int i = 0; i < n; i++)
    {
        result += (int)((Math.Pow(2, i) * b));

        Console.WriteLine(result + " ");
    }
}

static int minimumDistances(List<int> a)
{
    int minimumDistance = int.MaxValue;

    List<int> reminder = new List<int>();

    for (int i = 0; i < a.Count; i++)
    {
        reminder = a.Skip(i + 1).ToList();

        if (reminder.Contains(a[i]))
        {
            int currentDistance = Math.Abs((reminder.IndexOf(a[i]) + i + 1) - i);

            if (currentDistance < minimumDistance)
            {
                minimumDistance = currentDistance;
            }
        }
    }

    if (minimumDistance == int.MaxValue) 
    {
        return -1;
    }

    return minimumDistance;
}

static List<int> climbingLeaderboard(List<int> ranked, List<int> player)
{
    int[] results = new int[player.Count];

    int previous = int.MaxValue;
    int rank = 1;

    int iRanked = 0;
    int iPlayer = player.Count - 1;

    while (iPlayer >= 0)
    {
        if (iRanked < ranked.Count)
        {
            if (ranked[iRanked] > player[iPlayer])
            {
                if (ranked[iRanked] < previous)
                {
                    previous = ranked[iRanked];
                    ++rank;
                }

                ++iRanked;
                continue;
            }
        }

        results[iPlayer] = rank;
        --iPlayer;
    }

    return new List<int>(results);
}

static int minimumNumber(int n, string password)
{
    int countCharactersToAdd = 0;

    string specialCharacters = "!@#$%^&*()-+";

    bool hasDigit = password.Any(char.IsDigit);
    bool hasLowercase = password.Any(char.IsLower);
    bool hasUppercase = password.Any(char.IsUpper);
    bool hasSpecialCharacters = password.Any(c => specialCharacters.Contains(c));

    if(!hasDigit) { countCharactersToAdd++; }
    if(!hasLowercase) { countCharactersToAdd++; }
    if(!hasUppercase) { countCharactersToAdd++; }
    if(!hasSpecialCharacters) { countCharactersToAdd++; }

    if (6 > n + countCharactersToAdd)
    {
        countCharactersToAdd += 6 - n - countCharactersToAdd;
    }

    return countCharactersToAdd;
}


static int camelcase(string s)
{
    int count = 0;

    foreach (char c in s)
    {
        if (Char.IsUpper(c))
        {
            count++;
        }
    }

    return count;
}

static int pickingNumbers(List<int> a)
{
    var counts = new int[100];

    for (int i = 0; i < a.Count; i++)
    {
        counts[a[i]] = counts[a[i]] + 1;
    }

    var maxSubarrayLength = int.MinValue;
    for (int i = 0; i < a.Count - 1; i++)
    {
        var subarrayLength = counts[i] + counts[i + 1];
        if (subarrayLength > maxSubarrayLength)
        {
            maxSubarrayLength = subarrayLength;
        }
    }

    return maxSubarrayLength;
}

static string superReducedString(string s)
{
    if (s.Length == 0)
    {
        return "Empty String";
    }

    int oldLength = s.Length;
    int currentLength = oldLength;

    string result = "";

    if (s.Length > 1)
    {
        for (int i = 0; i < s.Length; i++)
        {
            if (i != s.Length - 1)
            {
                if (!(s[i] == s[i + 1]))
                {
                    result += s[i];
                }
                else
                {
                    i++;
                    currentLength -= 2;
                }
            }
            else
            {
                result += s[i];
            }
        }
    }
    else
    {
        return s;
    }

    if (oldLength != currentLength)
    {
        return superReducedString(result);
    }

    return result;
}

static string gameOfThrones(string s)
{
    Dictionary<char, int> map = new Dictionary<char, int>();

    foreach (char c in s)
    {
        if(!(map.Keys.Contains(c)))
        {
            map.Add(c, 1);
        }
        else
        {
            map[c]++;
        }
    }

    int countOdd = 0;

    foreach (char c in map.Keys) 
    {
        if (!(map[c] % 2 ==0))
        {
            countOdd++;
        }
    }

    if (countOdd > 1)
    {
        return "NO";
    }

    return "YES";
}

static int gemstones(List<string> arr)
{
    int count = 0;

    List<char> uniqueCharacters = new List<char>();

    foreach (string s in arr)
    {
        foreach (char c in s)
        {
            if (!(uniqueCharacters.Contains(c)))
            {
                uniqueCharacters.Add(c);
            }
        }
    }

    int countStrings = 0;

    foreach (char c in uniqueCharacters) 
    {
        countStrings = 0;

        foreach (string s in arr)
        {
            if (s.Contains(c)) 
            {
                countStrings++;
            }
        }

        if (countStrings == arr.Count)
        {
            count++;
        }
    }

    return count;
}

static int beautifulDays(int i, int j, int k)
{
    int count = 0;

    string normal = "";
    string reverse = "";

    int result = 0;

    for (int x = i; x <= j; x++)
    {
        normal = x.ToString();
        reverse = "";

        for (int z = normal.Length - 1; z >= 0; z--)
        {
            if(reverse == "" && normal[z] == '0')
            {
                continue;
            }
            else
            {
                reverse += normal[z];
            }
        }

        result = x - int.Parse(reverse);

        if (result % k == 0)
        {
            count++;
        }
    }

    return count;
}

static int pairs(int k, List<int> arr)
{
    int count = 0;

    foreach (int i in arr)
    {
        if (arr.Contains(i + k))
        {
            count++;
        }
    }

    return count;
}

static long repeatedString(string s, long n)
{
    int lengthOfTheString = s.Length;
    int countNumberOfAInString = 0;

    foreach (char c in s)
    {
        if (c == 'a')
        {
            countNumberOfAInString++;
        }
    }

    long getHowManyTimesItFullyRepeats = (long)Math.Floor((decimal)(n / lengthOfTheString));

    long getTheTotalNumberOfA = getHowManyTimesItFullyRepeats * countNumberOfAInString;

    int getLengthLeft = (int)(n % lengthOfTheString);

    if (getLengthLeft != 0)
    {
        for (int i = 0; i < getLengthLeft; i++)
        {
            if (s[i] == 'a')
            {
                getTheTotalNumberOfA++;
            }
        }
    }

    return getTheTotalNumberOfA;
}

static int viralAdvertising(int n)
{
    decimal cumulativeLikes = 2;
    decimal likes = 2;
    decimal shared = 5;

    for (int i = 0; i < n - 1; i++)
    {
        shared = Math.Floor(shared / 2) * 3;

        likes = Math.Floor(shared / 2);

        cumulativeLikes += likes;
    }
        
    return (int)cumulativeLikes;
}

static void insertionSort1(int n, List<int> arr)
{
    int number = arr[arr.Count - 1];

    int index = 0;

    for (int i = n; i > 0; i--)
    {
        index = i - 1;

        if(i != 1 && number < arr[index - 1])
        {
            arr[index] = arr[index - 1];

            Console.WriteLine(string.Join(' ', arr));
        }
        else
        {
            arr[index] = number;

            Console.WriteLine(string.Join(' ', arr));
            return;
        }
    }
}

static string encryption(string input)
{
    int rows = (int)Math.Floor(Math.Sqrt(input.Length));
    int columns = (int)Math.Ceiling(Math.Sqrt(input.Length));

    string result = "";

    List<string> resultedStrings = new List<string>();

    for (int i = 0; i < input.Length; i += columns)
    {
        List<char> split = input.Skip(i).Take(columns).ToList();

        resultedStrings.Add(string.Join("", split));
    }

    string encryption = "";
    int count = 0;

    for (int i = 0; i < columns; i++)
    {
        encryption = "";

        foreach (string s in resultedStrings)
        {
            try
            {
                encryption += s[i];
            }
            catch
            {
                continue;
            }
        }

        count++;
        result += encryption + " ";
    }

    return result;
}

static int howManyGames(int p, int d, int m, int s)
{
    // Return the number of games you can buy
    int currentMoney = s;
    int currentGamePrice = p;
    int countGames = 0;

    while (currentMoney >= currentGamePrice)
    {
        currentMoney -= currentGamePrice;
        countGames++;

        if (currentGamePrice >= m + d)
        {
            currentGamePrice -= d;
        }
        else if (currentGamePrice < m + d && currentGamePrice > m)
        {
            currentGamePrice = m;
        }
    }

    return countGames;
}

static void test()
{
    List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
    int n = 3;

    for (int i = 0; i < numbers.Count; i += n)
    {
        List<int> subList = numbers.Skip(i).Take(n).ToList();
        Console.WriteLine(string.Join(", ", subList));
    }
}

static int minimumLoss(List<long> price)
{
    long minimumLoss = int.MaxValue;
    Dictionary<long, int> pricesWithIndices = new Dictionary<long, int>();
    
    for (int i = 0; i < price.Count; i++)
    {
        pricesWithIndices.Add(price[i], i);
    }

    List<long> pricesSorted = pricesWithIndices.Keys.ToList();

    pricesSorted.Sort();

    long currentMinimumLoss = 0;

    int firstIndex = 0;
    int secondIndex = 0;

    long firstNumber = 0;
    long secondNumber = 0;
    
    for (int i = pricesSorted.Count - 1; i > 0; i--)
    {
        firstNumber = pricesSorted[i];
        secondNumber = pricesSorted[i - 1];

        pricesWithIndices.TryGetValue(firstNumber, out firstIndex);
        pricesWithIndices.TryGetValue(secondNumber, out secondIndex);

        if (!(firstIndex < secondIndex))
        {
            continue;
        }

        currentMinimumLoss = firstNumber - secondNumber;

        if (currentMinimumLoss < minimumLoss)
        {
            minimumLoss = currentMinimumLoss;
        }
    }

    return (int)minimumLoss;
}

class ListNode
{
    public int val;
    public ListNode next;
    public ListNode(int val = 0, ListNode next = null)
    {
        this.val = val;
        this.next = next;
    }
}

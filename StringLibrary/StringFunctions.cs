namespace StringLibrary {
    public class StringFunctions {

        //Reverse abc > cba
        public static string Reverse(string a) {
            char[] arr = a.ToCharArray();
            Array.Reverse(arr);
            return new string(arr);
        }
        public static string Rev(string a) {
            List<char> result = new List<char>();
            for (int idx = a.Length-1; idx >= 0; idx--) {
                result.Add(a[idx]);
            }
            return new string(result.ToArray());
        }
        //rotate
        public static string Rotate(string a) {
            List<char> result = new List<char>();
            result.Add(a[a.Length - 1]);
            for (int idx = 0; idx < a.Length - 1; idx++) {
                result.Add(a[idx]);
            }
            return new string(result.ToArray());
        }
        //remove vowels
        public static string RemoveVowels(string a) {
            char[] arr = a.ToCharArray(); //conver string a into an array of characters
            char[] vowels = { 'a', 'e', 'i', 'o', 'u', 'A', 'E', 'I', 'O', 'U' }; //array of characters containing vowels
            bool isVowel = false; //boolean to test if a character is a vowel
            List<char> result = new List<char>(); //where final results will go
            for (int idx = 0; idx < arr.Length; idx++) { //iterate through array (string a input) - looping over character in input
                isVowel = false;//resetting vowel test for next loop
                foreach (char vowel in vowels) { //loop through each vowel in vowel array
                    if (arr[idx] == vowel) {//see if character from input at spot index is at any point of vowel array
                        isVowel = true; //switch boolean to true
                    }
                }
                if (!isVowel) { //if boolean isn't switched, add that character from input to result
                    result.Add(arr[idx]);
                    
                } 
            }
            return new string(result.ToArray());
        }
    }
}
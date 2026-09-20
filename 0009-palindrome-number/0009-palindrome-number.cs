public class Solution {
    public bool IsPalindrome(int x) {
         int Reverse(int n){
            int reversed = 0;
            while(n>0){
                int digit= n%10;
                reversed = reversed*10 +digit;
                n/=10;
            }
            return reversed;
        }
        return x == Reverse(x);
    }
}
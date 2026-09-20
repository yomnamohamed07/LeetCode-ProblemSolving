public class Solution {
    public int MySqrt(int x) {
       if(x== 0 || x==1) {
         return x;
       }
     int low = 1 ;int high = x; int ans= 0;
      while(low <= high){
        int mid = low +(high - low)/2;
        if((long)mid * mid == x){
            return mid;}
            if((long)mid *mid <x){
                low = mid+1;
                ans= mid ;
            }else{
                high =mid-1;
            }
        }
        return ans;
      }
    }

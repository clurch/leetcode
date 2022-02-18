public class ClimbStairsSolution {
    public int ClimbStairs(int n) {
        var prev = 0;
        var next = 1;
        var count = 0;
        var total = 0;
        
        while (count < n) {
            total = prev + next;
            prev = next;
            next = total;
            count++;
        }
            
        return total;
    }
}
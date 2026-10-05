import java.util.Scanner;

// --- POOR CODE QUALITY SCRIPT (WHAT MAKES IT POOR?) ---
public class Activity2 {
    public static void main(String[] args) {
        Scanner sc=new Scanner(System.in);
        int x=0;String s="";
        while(true){
                System.out.print("what is it? ");
                String a=sc.nextLine();
                if(a.equals("exit")){
                  break;
                }
                else{
                      System.out.print("type: ");
                      String b=sc.nextLine();
                      System.out.print("time: ");
                      int c=Integer.parseInt(sc.nextLine());
                      x=x+c;s=s+"Task: "+a+" | Cat: "+b+" | Mins: "+c+"\n";
                      System.out.println("saved");
                }
        }
        System.out.println("\n--- DAILY WORK LOG ---");
        System.out.println(s);
        System.out.println("----------------------------");
        System.out.println("Total Duration: "+x+" minutes");
    }
}

using System;
					
public class Program
{
  private string testWord="solos";
	public static void Main()
	{
  var result = QuasiPalindromo(testWord);
	Console.WriteLine(result);
	}
	
 public static Boolean QuasiPalindromo(string word){
   int count = 0;
	 bool result = false;
	 for(var i = 0; i<word.Length/2; i++)
	 {
		result=word[i]==word[word.Length-(i+1)];
		 if (!result)
		 {
			 count++;
		 }		 
	 }
	 if(count<1)
	 {
		 result = true;
	 }
	 return result;        	
    }	
}

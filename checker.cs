using System;
using System.Diagnostics;

class Checker
{
    static bool vitalsAreOk(float bpm, float spo2, float respRate) {
      bool ans=true;
      ans&=isBpmLowerLimit(bpm)&isBpmUpperLimit(bpm)&isSpo2Ok(spo2)&isRespRateLowerLimit(respRate)&isRespRateUpperLimit(respRate);
      return ans;
    
    }
    static bool isBpmLowerLimit(float bpm){
          if(bpm>=70)
              return true;
          return false;
    }
    
    static bool isBpmUpperLimit(float bpm){
          if(bpm<=150)
              return true;
          return false;
    }
    
    static bool isSpo2Ok(float spo2){
          if(spo2>=90)
              return true;
          return false;
    }
    
    static bool isRespRateLowerLimit(float respRate){
          if(respRate>=30)
              return true;
          return false;
    }
    
    static bool isRespRateUpperLimit(float respRate){
          if(respRate<=95)
              return true;
          return false;
    }    
    static void ExpectTrue(bool expression) {
        if(!expression) {
            Console.WriteLine("Expected true, but got false");
            Environment.Exit(1);
        }
    }
    static void ExpectFalse(bool expression) {
        if(expression) {
            Console.WriteLine("Expected false, but got true");
            Environment.Exit(1);
        }
    }
    static int Main() {
        ExpectTrue(vitalsAreOk(100, 95, 60));
        ExpectFalse(vitalsAreOk(40, 91, 92));
        ExpectFalse(vitalsAreOk(71, 89, 92));
        ExpectFalse(vitalsAreOk(75, 91, 99));
        ExpectFalse(vitalsAreOk(75, 70, 20));
        ExpectFalse(vitalsAreOk(40, 65, 92));
        ExpectFalse(vitalsAreOk(40, 91, 97));
        ExpectFalse(vitalsAreOk(40, 75, 98));
         
        Console.WriteLine("All ok");
        return 0;
    }
}

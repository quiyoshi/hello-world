using System;

class HelloWorld{
  static void main(String args[]){
    Counting cont = new Counting();

    for(int i = 0; i < cont.repeat(); i++){
      Console.WriteLine(echo_hello());
    }
  }

  String echo_hello(){
    return "Hello World";
  }
}

class Counting{
  public Counting(){
    Console.WriteLine("oppai");
  }

  int repeat(){
    return 7:
  }
}

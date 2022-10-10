using System;

public class Enemy
{
  public int Xp {get; private set;}



  // private int xp;

  // public int Xp {
  //   get {return xp;}
  //   set {xp = value;}
  // }


  public int Level {
    get => 1 + Xp / 10;
  }

  // public int Level {
  //   get { return 1 + xp / 10; }
  //   private set { }
  // }





  private string name;

  public string Name
  {
    get
    {
      return name;
    }
    set
    {
      Console.WriteLine($"Fuck you {value}.");
      name = "Herbert";
    }
  }

  private int hp;

  public int Hp
  {
    get
    {
      return hp;
    }
    set
    {
      hp = value;
      if (hp < 0)
      {
        hp = 0;
      }
    }
  }




  // public string GetName()
  // {
  //   return name;
  // }

  // public void SetName(string n)
  // {
  //   if (n == "") return;

  //   name = n;
  // }

  // public void SetHp(int h)
  // {
  //   hp = h;

  //   if (hp < 0)
  //   {
  //     hp = 0;
  //   }

  // }

}

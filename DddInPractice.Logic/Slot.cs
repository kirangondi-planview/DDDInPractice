﻿namespace DddInPractice.Logic
{
  public class Slot : Entity
  {
    public virtual Snack Snack { get; set; }
    public virtual int Quantity { get; set; }
    public virtual decimal Price { get; set; }
    public virtual SnackMachine SnackMachine { get; set; }
    public virtual int Position { get; set; }

    protected Slot()
    {

    }

    public Slot(SnackMachine snackMachine, int position, Snack snack, int quantity, decimal price) : this()
    {
      SnackMachine = snackMachine;
      Position = position;
      Snack = snack;
      Quantity = quantity;
      Price = price;
    }
  }
}

using System;
using Microsoft.AspNetCore.Mvc;
namespace TutorialDotNet.Models{
  public class Products 
  {
    public int ID{get;set;}
    public string  ProductID{get;set;}
    public string Name {get;set;}
    public string Detail {get;set;}
    public decimal Price {get;set;}
    public int CategoryId {get;set;}
    public string image {get;set;}
    public DateTime Timestamp {get;set;}
    public Category Categories {get;set;}
    
  }
}
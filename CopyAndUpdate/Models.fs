namespace CopyAndUpdate

open System;

[<CLIMutable>]
type FModel = 
      { A: string
        B: string }
      interface ICloneable with 
            member x.Clone() = x.MemberwiseClone()

type DataObject =
      { Id : int
        Value: string
        Object: DataObject2 }
and DataObject2 = 
      { Price: decimal
        PriceType: string }


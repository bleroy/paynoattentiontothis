namespace Library
open System
open Newtonsoft.Json

module Thing =
    let get x = JsonConvert.DeserializeObject<int>(sprintf "%A" x)

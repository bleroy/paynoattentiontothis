namespace Test

open Xunit
open Library

module TestyMcTestFace =
    [<Fact>]    
    let ``Super-happy fun times``() = Assert.Equal(42, Thing.get 42)
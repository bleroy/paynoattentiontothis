open System
open MyAwesomeLibrary.Core

module Lib =
    let GetMessage name = name |> LibCore.GetMessage
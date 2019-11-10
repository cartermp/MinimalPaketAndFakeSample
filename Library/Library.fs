namespace Library

open Newtonsoft.Json

module Message =
    let private name = "Phillip Carter"

    let getNameAsJson = JsonConvert.SerializeObject(name)

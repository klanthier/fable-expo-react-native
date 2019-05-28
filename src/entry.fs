module AwesomeApp.EntryPoint

open Fable.Core
open Fable.React
open Fable.ReactNative
open AwesomeApp.Main

let entryView props =
    view [ Styles.entryContainer ] [
        welcome "Fable-Expo-RN"
    ]


let Entry props = ofFunction entryView null []

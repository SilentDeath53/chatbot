type Chatbot() =
    member this.Respond(message: string) =
        match message.ToLower() with
        | "hello" -> "Hello! How can I assist you?"
        | "how are you?" -> "I'm doing well, thank you. How about you?"
        | "what is your name?" -> "My name is Chatbot. Nice to meet you!"
        | _ -> "I'm sorry, I didn't understand. Can you please rephrase your question?"

// Usage example
let chatbot = Chatbot()
printfn "User: Hello"
printfn "Chatbot: %s" (chatbot.Respond("Hello"))
printfn "User: What is your name?"
printfn "Chatbot: %s" (chatbot.Respond("What is your name?"))
printfn "User: How are you?"
printfn "Chatbot: %s" (chatbot.Respond("How are you?"))
printfn "User: What is the weather like today?"
printfn "Chatbot: %s" (chatbot.Respond("What is the weather like today?"))

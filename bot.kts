// dependencies {
//    implementation("net.dv8tion:JDA:4.3.0_324")
//}

import net.dv8tion.jda.api.JDABuilder
import net.dv8tion.jda.api.entities.Activity
import net.dv8tion.jda.api.events.message.MessageReceivedEvent
import net.dv8tion.jda.api.hooks.ListenerAdapter
import javax.security.auth.login.LoginException

class MyBot : ListenerAdapter() {
    override fun onMessageReceived(event: MessageReceivedEvent) {
        val message = event.message
        val content = message.contentRaw

        if (content.equals("!hello", ignoreCase = true)) {
            val author = message.author
            message.channel.sendMessage("Hi, ${author.asMention}!").queue()
        }
    }
}

fun main() {
    val token = "YOUR_BOT_TOKEN_HERE" // Replace with your token

    try {
        JDABuilder.createDefault(token)
            .addEventListeners(MyBot())
            .setActivity(Activity.playing("Code on Kotlin"))
            .build()
    } catch (e: LoginException) {
        e.printStackTrace()
    }
}

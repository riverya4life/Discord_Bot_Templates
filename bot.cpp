#include <iostream>
#include <discordcpp/rest_api.hpp>
#include <discordcpp/websocket.hpp>

using namespace discordcpp;

int main() {
    std::string token = "YOUR_BOT_TOKEN"; // Replace YOUR_BOT_TOKEN with your bot token.

    auto api = rest_api(token);
    auto ws = websocket(token);

    api.on_message([&](const message &msg) {
        if (msg.content == "ping") {
            api.send_message(msg.channel_id, "pong");
        }
    });

    ws.on_ready([&]() {
        std::cout << "Bot is ready!" << std::endl;
    });

    ws.run();

    return 0;
}

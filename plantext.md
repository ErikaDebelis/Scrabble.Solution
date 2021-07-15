Make a console application that takes a word and returns the Scrabble score for that word. Make sure to start with your specs, and that you include a README for this project and create a Git repository for it. Here are the values of letters in Scrabble:
A, E, I, O, U, L, N, R, S, T       1
D, G                               2
B, C, M, P                         3
F, H, V, W, Y                      4
K                                  5
J, X                               8
Q, Z                               10



Dictionary<char, int> scrabble = new Dictionary<char, int>() {
  {"A", 1}, {"E", 1}, {"I", 1},
  {"D", 2},

}


// >  Dictionary<string, int> cupcakeOrder = new Dictionary<string, int>() { {"vanilla", 12}, {"chocolate", 24}, {"raspberry", 6}, {"caramel apple", 36} };

// // > cupcakeOrder["vanilla"] // How many vanilla cupcakes do we want?
// 12

// > cupcakeOrder["chocolate"] // How many chocolate?
// 24

// > cupcakeOrder["raspberry"]
// 6

// > cupcakeOrder["caramel apple"]
// 36
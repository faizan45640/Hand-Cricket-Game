--using database handcricket

--basic tables for the hand cricket game
CREATE Table Player(
    id INT PRIMARY KEY IDENTITY (1,1),
    userName VARCHAR(50) NOT NULL,
    password VARCHAR(255) NOT NULL,
    gender VARCHAR(10) NOT NULL,
    picture VARBINARY(MAX));


CREATE TABLE PlayerStats (
    id INT PRIMARY KEY IDENTITY (1,1),
    playerId INT,
    matchesPlayed INT NOT NULL DEFAULT 0,
    matchesWon INT NOT NULL DEFAULT 0,
    matchesLost INT NOT NULL DEFAULT 0,
    runsScored INT NOT NULL DEFAULT 0,
    wicketsTaken INT NOT NULL DEFAULT 0,
    sixes INT NOT NULL DEFAULT 0,
    fours INT NOT NULL DEFAULT 0,
    ballsBowled INT NOT NULL DEFAULT 0,
    ballsFaced INT NOT NULL DEFAULT 0,
    fifties INT NOT NULL DEFAULT 0,
    hundreds INT NOT NULL DEFAULT 0,
    strikeRate FLOAT NOT NULL DEFAULT 0,
    economy FLOAT NOT NULL DEFAULT 0,
    average FLOAT NOT NULL DEFAULT 0,
    bestBowling VARCHAR(50) NOT NULL DEFAULT '0/0',
    highestScore INT NOT NULL DEFAULT 0,
    FOREIGN KEY (playerId) REFERENCES Player(id)
);


CREATE TABLE Match (
    id INT PRIMARY KEY IDENTITY (1,1),
    player1Id INT,
    player2Id INT,
    player1Score INT NOT NULL DEFAULT 0,
    player2Score INT NOT NULL DEFAULT 0,
    player1Wickets INT NOT NULL DEFAULT 0,
    player2Wickets INT NOT NULL DEFAULT 0,
    player1BallsBowled INT NOT NULL DEFAULT 0,
    player2BallsBowled INT NOT NULL DEFAULT 0,
    player1Sixes INT NOT NULL DEFAULT 0,
    player2Sixes INT NOT NULL DEFAULT 0,
    player1Fours INT NOT NULL DEFAULT 0,
    player2Fours INT NOT NULL DEFAULT 0,
    WinnerId INT,
    matchDate DATE DEFAULT GETDATE(),
    FOREIGN KEY (player1Id) REFERENCES Player(id),
    FOREIGN KEY (player2Id) REFERENCES Player(id),
    FOREIGN KEY (WinnerId) REFERENCES Player(id)
);


    







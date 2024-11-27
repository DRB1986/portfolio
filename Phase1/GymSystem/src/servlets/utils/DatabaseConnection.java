package utils;

import java.sql.Connection;
import java.sql.DriverManager;
import java.sql.SQLException;

public class DatabaseConnection {

    public static Connection getConnection() throws SQLException {
        String url = "jdbc:sqlserver://localhost:1433;databaseName=GymSystem;";
        String user = "your_db_username";  // Replace with your database username
        String password = "your_db_password";  // Replace with your database password
        
        return DriverManager.getConnection(url, user, password);
    }
}
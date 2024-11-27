package servlets;

import utils.DatabaseConnection;
import java.io.*;
import javax.servlet.*;
import javax.servlet.http.*;
import java.sql.*;

public class SaveIntroServlet extends HttpServlet {
    protected void doPost(HttpServletRequest request, HttpServletResponse response) throws ServletException, IOException {
        String username = request.getParameter("username");
        String introduction = request.getParameter("introduction");
        String hobbies = request.getParameter("hobbies");

        try (Connection conn = DatabaseConnection.getConnection()) {
            String sql = "INSERT INTO UserDetails (id, introduction, hobbies) " +
                         "VALUES ((SELECT id FROM Users WHERE username = ?), ?, ?)";
            try (PreparedStatement stmt = conn.prepareStatement(sql)) {
                stmt.setString(1, username);
                stmt.setString(2, introduction);
                stmt.setString(3, hobbies);
                stmt.executeUpdate();
            }
            response.sendRedirect("introTable.html");
        } catch (SQLException e) {
            e.printStackTrace();
        }
    }
}
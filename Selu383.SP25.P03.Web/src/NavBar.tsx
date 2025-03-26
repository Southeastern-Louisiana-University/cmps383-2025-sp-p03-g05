import React from "react";
import { AppBar, Toolbar, Typography, Box, Button } from "@mui/material";

const NavBar = () => {
  return (
    <AppBar position="static" sx={{ backgroundColor: "#333" }}>
      <Toolbar sx={{ display: "flex", justifyContent: "space-between" }}>
        
        {/* Logo or Website Title */}
        <Typography variant="h6" sx={{ fontWeight: "bold" }}>
          My Website
        </Typography>

        {/* Menu Items (No Links) */}
        <Box>
          <Button sx={{ color: "white", mx: 1 }}>See a Movie</Button>
          <Button sx={{ color: "white", mx: 1 }}>Find a Theater</Button>
          <Button sx={{ color: "white", mx: 1 }}>Food and Drinks</Button>
          <Button sx={{ color: "white", mx: 1 }}>More</Button>
        </Box>

      </Toolbar>
    </AppBar>
  );
};

export default NavBar;

//import React from "react";
import { AppBar, Toolbar, Box, Button, Link } from "@mui/material";

const NavBar = () => {
  return (
    <AppBar position="static" sx={{ backgroundColor: "#333" }}>
      <Toolbar sx={{ display: "flex", justifyContent: "space-between" }}>
        
        {/* Logo or Website Title */}
        {/* <Typography variant="h6" sx={{ fontWeight: "bold" }}>
          My Website
        </Typography> */}

        {/* Menu Items (No Links) */}
        <Box>
          <Button sx={{ color: "white", mx: 1 }}>See a Movie</Button>
          <Link href="/location"><Button sx={{ color: "white", mx: 1 }}>Find a Theater</Button></Link>
          <Button sx={{ color: "white", mx: 1 }}>Food and Drinks</Button>
          <Button sx={{ color: "white", mx: 1 }}>More</Button>
        </Box>

      </Toolbar>
    </AppBar>
  );
};

export default NavBar;

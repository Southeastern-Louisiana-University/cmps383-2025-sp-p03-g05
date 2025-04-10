//import React from "react";
import { Box, Link, Container, Typography, Stack } from "@mui/material";

const menuItems = (
  <>
    <Typography
      component={Link}
      href="/movies"
      fontWeight={600}
      color="#a800b7"
    >
      Now Showing
    </Typography>

    <Typography
      component={Link}
      href="/location"
      fontWeight={600}
      color="#a800b7"
    >
      Theaters
    </Typography>

    <Typography component={Link} href="/" fontWeight={600} color="#a800b7">
      Food & Drinks
    </Typography>
    <Typography component={Link} href="/login" fontWeight={600} color="#a800b7">
      Sign In
    </Typography>
  </>
);

const NavBar = () => {
  return (
    <Box
      sx={{
        width: "100%",
        backgroundColor: "#121212",
        boxShadow: "0px 4px 4px rgba(0,0,0,0.1)",
        padding: "20px 0px",
        "& a": { textDecoration: "none" },
      }}
    >
      <Container>
        <Stack
          direction="row"
          justifyContent="space-between"
          alignItems="center"
          sx={{
            padding: "8px 0",
          }}
        >
          {/*<Box
            component="img"
            sx={{ height: 50, width: 50 }}
            src="./LDCDark.png"
          ></Box>*/}

          <Box component={Link} href="/" color="#a800b7" underline="none">
            <Typography fontWeight={600} variant="h5">
              Lions Den Cinemas
            </Typography>
          </Box>

          <Stack
            direction="row"
            gap={4}
            alignItems="center"
            sx={{
              "& a:hover": {
                transition: "ease-in-out 0.2s",
              },
              display: {
                xs: "none",
                sm: "none",
                md: "none",
                lg: "flex",
                xl: "flex",
              },
            }}
          >
            {menuItems}
          </Stack>
        </Stack>
      </Container>
    </Box>
  );
};
export default NavBar;

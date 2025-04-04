//import React from "react";
import { Box, Link, Container, Typography, Stack } from "@mui/material";
import { useState } from "react";

const menuItems = (
  <>
    <Typography
      component={Link}
      href="/movies"
      fontWeight={600}
      color="#a800b7"
    >
      See a Movie
    </Typography>

    <Typography component={Link} href="/" fontWeight={600} color="#a800b7">
      Find a Theatre
    </Typography>

    <Typography component={Link} href="/" fontWeight={600} color="#a800b7">
      Food & Drinks
    </Typography>
    <Typography component={Link} href="/" fontWeight={600} color="#a800b7">
      Sign In
    </Typography>
  </>
);

const NavBar = () => {
  const [open, setOpen] = useState<boolean>(false);

  const handleDrawerOpen = () => {
    setOpen(true);
  };

  const handleDrawerClose = () => {
    setOpen(false);
  };

  return (
    <Stack>
      <Box
        sx={{
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
            {/* logo*/}
            <Box component={Link} href="/" color="#a800b7">
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
                  textDecoration: "underline",
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
    </Stack>
  );
};
export default NavBar;

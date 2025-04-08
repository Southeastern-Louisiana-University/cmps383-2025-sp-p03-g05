import {
  Box,
  Container,
  Typography,
  Stack,
} from "@mui/material";
import { Link as RouterLink } from "react-router-dom"; // Use React Router's Link
import { useState } from "react";

const NavBar = () => {
  const [open, setOpen] = useState(false);

  const menuItems = (
    <>
      <Typography component={RouterLink} to="/" fontWeight={600} color="#a800b7">
        See a Movie
      </Typography>
      <Typography component={RouterLink} to="/" fontWeight={600} color="#a800b7">
        Find a Theatre
      </Typography>
      <Typography component={RouterLink} to="/" fontWeight={600} color="#a800b7">
        Food & Drinks
      </Typography>
      <Typography component={RouterLink} to="/login" fontWeight={600} color="#a800b7">
        Sign In
      </Typography>
    </>
  );

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
            sx={{ padding: "8px 0" }}
          >
            {/* Logo + Brand name */}
            <Box
              component={RouterLink}
              to="/"
              sx={{
                display: "flex",
                alignItems: "center",
                gap: 1.5,
                color: "#a800b7",
                textDecoration: "none",
              }}
            >
              <img
                src="/LDC.png"
                alt="Lions Den Logo"
                style={{ height: 40 }}
              />
              <Typography fontWeight={600} variant="h5">
                Lions Den Cinemas
              </Typography>
            </Box>

            {/* Menu Items */}
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

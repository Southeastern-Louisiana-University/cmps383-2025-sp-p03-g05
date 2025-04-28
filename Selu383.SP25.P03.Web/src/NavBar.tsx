import { Box, Link, Container, Typography, Stack } from "@mui/material";
import  { useState } from 'react';
import LoginDialog from './LoginDialog'


const NavBar = () => {

  const [open, setOpen] = useState(false);

const handleOpenDialog = () => {
  setOpen(true);
};

const handleCloseDialog = () => {
  setOpen(false);
};

const handleSubmit = (email: string, password: string) => {
  alert(`Logged in with ${email} and password ${password}`);
};


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
    <Typography component={Link} href="/comingsoon" fontWeight={600} color="#a800b7">
      Coming Soon
    </Typography>

    <Typography
      component={Link}
      href="/theaters"
      fontWeight={600}
      color="#a800b7"
    >
      Theaters
    </Typography>

    <Typography component={Link} href="/" fontWeight={600} color="#a800b7">
      Food & Drinks
    </Typography>
    <Typography component={Link} onClick={handleOpenDialog} fontWeight={600} color="#a800b7" >
      Sign In
    </Typography>
    <LoginDialog open={open} handleCloseDialog={handleCloseDialog} onSubmit={handleSubmit} />
  </>
);
  
  return (
    <>
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
            <Box component={Link} href="/" color="#a800b7" underline="none">
              <Typography fontWeight={600} variant="h5">
                Lion's Den Cinemas
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
    </>
  );
};
export default NavBar;



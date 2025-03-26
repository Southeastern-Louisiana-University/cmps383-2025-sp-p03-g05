import { Button, Divider, Typography } from '@mui/material';
import './Home.css'
import MovieCarousel from "./MovieCarousel"
import NavBar from './NavBar';
import AccountCircleIcon from '@mui/icons-material/AccountCircle';
import { Margin } from '@mui/icons-material';

function Home() {
    

    return(
        <>
        <div className="topBanner">
            <div style={{width: "70px", height: "50px"}}>

            <img 
                src="/LDCDark.png" 
                alt="Corner Icon" 
                style={{ width: "50px", height: "50px", position: "absolute", top: "10px", left: "10px" }} 
            />
            </div>
            <div>
                {NavBar()}
            </div>
            <div>
                <Button style={{margin: "30px"}}>
                    <AccountCircleIcon style={{color: "black"}}></AccountCircleIcon>
                    <Typography variant="h6" sx={{ fontWeight: "bold" }} style={{color: "black"}}>
                        Profile
                    </Typography>
                </Button>
            </div>
            
        </div>
        <div className = "middleBanner">
            {/* <hr style={{ width: "100%", border: "2px solid black", margin: "20px 0" }} /> */}
            <Typography variant="h3" sx={{ fontWeight: "bold" }} style={{color: "white", margin: "50px"}}>
                        Movies Out
                    </Typography>
            <Divider sx={{ '--Divider-childPosition': `50%` }}>
            </Divider>
            {MovieCarousel()}
        </div>
        <div className = "bottomBanner">

        </div>
        
        
        
        </>

    )
}

export default Home;
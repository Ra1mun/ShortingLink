import { Box } from "@chakra-ui/react";
import ShortingLinkForm from "../components/ShortingLinkForm";
import Background from "../components/Background";

function Home(){
    return(
        <Box
            marginTop = '5px'
            height="100%"
            display="flex"
            alignItems="center"
            justifyContent="center"
        >
            <ShortingLinkForm />
            
        </Box>
    );
}

export default Home;
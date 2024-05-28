import { Box,
     Input,
     FormControl,
     FormLabel,
     FormErrorMessage,
     FormHelperText,
     Button } from "@chakra-ui/react";


function ShortingLinkForm(){
    return(
        <Box>
            <FormControl
                height="100%"
                display="block"
                align="center"
                text-align='center'
                vertical-align='middle'
            >
                <FormLabel
                    text-align='center'
                >Введите ссылку</FormLabel>
                    <Input 
                        variant='flushed' 
                        placeholder='Полная'
                        type='url' />
                    <Button
                        type='submit'
                        marginTop='5px'
                    >Отправить</Button>
            </FormControl>
        </Box>
    );
}

export default ShortingLinkForm;
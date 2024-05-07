import { Button, Container, Image, Nav, Navbar } from "react-bootstrap";

interface Props {
    openform: (id:string) => void;
}

export default function NavBar({openform}:Props) {
    return (
        <Navbar expand="lg" bg="dark" data-bs-theme="dark">
            <Container>
                <Nav className="ml-auto">
                    <Image src="assets/logo.png" alt="50*50" width="30" height="35" style={{ marginRight: '10px', marginTop: '3px' }} />
                    <Navbar.Brand href="#home">
                        Activities
                    </Navbar.Brand>
                    <Nav.Link href="#home"> Home </Nav.Link>
                    <Button variant="success" onClick={()=>openform("")}>Create Activity</Button>{' '}
                </Nav>
            </Container>
        </Navbar>
    )
}
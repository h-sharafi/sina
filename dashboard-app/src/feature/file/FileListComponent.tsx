import React, { useContext } from 'react'
import { CardGroup, Card } from 'react-bootstrap';
import { IFile } from '../../app/models/file';
import { observer } from 'mobx-react-lite';
import { RootStoreContext } from '../../app/stores/rootStore';
import { fileURLToPath } from 'url';
interface IProps {
    files: IFile[]
}
const FileListComponent: React.FC<IProps> = ({ files }) => {
    const rootStore = useContext(RootStoreContext);
    let fileUrl = rootStore.url
    return (
        <div>
            <CardGroup>
                {files.map((file) => {
                    return (
                        <Card key={file.id}>
                            <Card.Img variant="top" src={`${fileUrl}/${file.name}`} />
                            <Card.Body>
                                <Card.Title>{file.title}</Card.Title>
                                <Card.Text></Card.Text>
                            </Card.Body>
                            <Card.Footer>
                                <small className="text-muted">{file.CreationTime}</small>
                            </Card.Footer>
                        </Card>
                    )
                })}
            </CardGroup>
        </div>
    )
}

export default observer(FileListComponent)

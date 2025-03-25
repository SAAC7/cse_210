class Video
{
    public string _Title { get;set;}
    public string _Author { get;set;}   
    public int _LengthInSeconds { get; set; }
    private List<Comment> _Comments;

    public Video( string _Title,string _Author, int _LengthInSeconds){
        this._Title = _Title;
        this._Author = _Author;
        this._LengthInSeconds = _LengthInSeconds;
        _Comments = new List<Comment>();

    }


    public void AddComment (Comment comment){
        _Comments.Add (comment);
    }
    public int GetNumberOfComments (){
        return _Comments.Count;
    }
    public List<Comment> GetComments(){
        return _Comments;
    }


}
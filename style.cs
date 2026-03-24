:root {
    --bg:      #080706;                                                                                                                                                                                        
    --s1:      #0f0e0c;                                                                                                                                                                                        
    --s2:      #161410;
    --border:  #252015;                                                                                                                                                                                        
    --border2: #342c1e;
    --accent:  #c97a4e;                                                                                                                                                                                        
    --accent2: #e8a86a;                                                                                                                                                                                        
    --text:    #f5f2ed;                                                                                                                                                                                        
    --muted:   #a09588;                                                                                                                                                                                        
    --dim:     #6b5f54;                                                                                                                                                                                        
    --red:     #b85050;
  }                                                                                                                                                                                                            
                  
  *, *::before, *::after { margin: 0; padding: 0; box-sizing: border-box; }                                                                                                                                    
  html { scroll-behavior: smooth; }
  body {                                                                                                                                                                                                       
    background: var(--bg);
    color: var(--text);
    font-family: -apple-system, 'Helvetica Neue', Helvetica, Arial, sans-serif;                                                                                                                                
    font-size: 16px;
    line-height: 1.6;                                                                                                                                                                                          
    min-height: 100vh;
    -webkit-font-smoothing: antialiased;                                                                                                                                                                       
  }               

  .wrap {                                                                                                                                                                                                      
    position: relative; z-index: 1;
    max-width: 680px;                                                                                                                                                                                          
    margin: 0 auto;
    padding: 0 28px;
  }                                                                                                                                                                                                            
   
  header {                                                                                                                                                                                                     
    position: fixed; top: 0; left: 0; right: 0; z-index: 100;
    padding: 24px 32px;
    display: flex; justify-content: space-between; align-items: center;                                                                                                                                        
  }
  .header-tag {                                                                                                                                                                                                
    font-size: 11px; letter-spacing: .16em;                                                                                                                                                                    
    text-transform: uppercase; color: var(--dim);
  }                                                                                                                                                                                                            
                  
  #landing { min-height: 100vh; display: flex; flex-direction: column; justify-content: center; padding: 120px 0 80px; }                                                                                       
                  
  .eyebrow {                                                                                                                                                                                                   
    font-size: 11px; letter-spacing: .2em;
    text-transform: uppercase; color: var(--accent);                                                                                                                                                           
    margin-bottom: 32px;
    display: flex; align-items: center; gap: 10px;                                                                                                                                                             
  }                                                                                                                                                                                                            
  .eyebrow::before {
    content: '';                                                                                                                                                                                               
    display: block; width: 24px; height: 1px;
    background: var(--accent);                                                                                                                                                                                 
  }               

  h1 {
    font-size: clamp(38px, 7vw, 68px);
    font-weight: 300;                                                                                                                                                                                          
    letter-spacing: -.03em;
    line-height: 1.05;                                                                                                                                                                                         
    margin-bottom: 28px;
    color: var(--text);                                                                                                                                                                                        
  }                                                                                                                                                                                                            
  h1 em { font-style: normal; color: var(--accent2); }
                                                                                                                                                                                                               
  .sub {                                                                                                                                                                                                       
    font-size: clamp(16px, 2.5vw, 19px);
    color: var(--muted);                                                                                                                                                                                       
    max-width: 520px;
    line-height: 1.65;                                                                                                                                                                                         
    margin-bottom: 52px;
    font-weight: 300;                                                                                                                                                                                          
  }               
  .sub strong { color: var(--text); font-weight: 400; }
                                                                                                                                                                                                               
  .form-wrap {
    display: flex; gap: 10px; flex-wrap: wrap;                                                                                                                                                                 
    margin-bottom: 20px;
  }                                                                                                                                                                                                            
  .form-wrap input[type="email"] {
    flex: 1; min-width: 220px;                                                                                                                                                                                 
    background: var(--s1);
    border: 1px solid var(--border2);                                                                                                                                                                          
    border-radius: 10px;
    padding: 14px 18px;                                                                                                                                                                                        
    font-size: 15px;                                                                                                                                                                                           
    color: var(--text);
    outline: none;                                                                                                                                                                                             
    transition: border-color .2s, box-shadow .2s;
    font-family: inherit;                                                                                                                                                                                      
  }
  .form-wrap input[type="email"]::placeholder { color: var(--dim); }                                                                                                                                           
  .form-wrap input[type="email"]:focus {                                                                                                                                                                       
    border-color: var(--accent);
    box-shadow: 0 0 0 3px rgba(201,122,78,.12);                                                                                                                                                                
  }                                                                                                                                                                                                            
  .btn {
    background: var(--accent);                                                                                                                                                                                 
    color: #0a0806;
    border: none; border-radius: 10px;                                                                                                                                                                         
    padding: 14px 26px;                                                                                                                                                                                        
    font-size: 14px; font-weight: 600;                                                                                                                                                                         
    letter-spacing: .04em;                                                                                                                                                                                     
    cursor: pointer;                                                                                                                                                                                           
    transition: background .2s, transform .1s;
    font-family: inherit;                                                                                                                                                                                      
    white-space: nowrap;
  }
  .btn:hover { background: var(--accent2); }                                                                                                                                                                   
  .btn:active { transform: scale(.98); }
  .btn:disabled { opacity: .5; cursor: not-allowed; }                                                                                                                                                          
                                                                                                                                                                                                               
  .form-note { font-size: 12px; color: var(--dim); margin-top: 12px; }                                                                                                                                         
  .error-msg { font-size: 12px; color: var(--red); margin-top: 8px; display: none; }                                                                                                                           
                                                                                                                                                                                                               
  .resonators {   
    margin: 80px 0;                                                                                                                                                                                            
    border-top: 1px solid var(--border);
    padding-top: 64px;                                                                                                                                                                                         
  }
  .resonators-label {                                                                                                                                                                                          
    font-size: 11px; letter-spacing: .18em;
    text-transform: uppercase; color: var(--dim);                                                                                                                                                              
    margin-bottom: 40px;
  }                                                                                                                                                                                                            
  .resonator {    
    padding: 24px 0;
    border-bottom: 1px solid var(--border);                                                                                                                                                                    
    display: flex; gap: 20px; align-items: flex-start;
  }                                                                                                                                                                                                            
  .resonator:last-child { border-bottom: none; }
  .r-num { font-size: 11px; color: var(--dim); padding-top: 3px; min-width: 20px; }                                                                                                                            
  .r-text { font-size: clamp(16px, 2.5vw, 18px); color: var(--muted); font-weight: 300; line-height: 1.55; }                                                                                                   
  .r-text strong { color: var(--text); font-weight: 400; }                                                                                                                                                     
                                                                                                                                                                                                               
  .mystery {                                                                                                                                                                                                   
    background: var(--s1);                                                                                                                                                                                     
    border: 1px solid var(--border);
    border-radius: 16px;
    padding: 48px 40px;                                                                                                                                                                                        
    margin: 40px 0 80px;
    text-align: center;                                                                                                                                                                                        
  }               
  .mystery-tag {                                                                                                                                                                                               
    display: inline-block;
    background: var(--bg); border: 1px solid var(--border2);                                                                                                                                                   
    border-radius: 20px; padding: 4px 14px;                                                                                                                                                                    
    font-size: 11px; letter-spacing: .14em;
    text-transform: uppercase; color: var(--dim);                                                                                                                                                              
    margin-bottom: 24px;
  }                                                                                                                                                                                                            
  .mystery h2 { font-size: clamp(22px, 4vw, 32px); font-weight: 300; letter-spacing: -.02em; margin-bottom: 16px; color: var(--text); }                                                                        
  .mystery p { font-size: 15px; color: var(--muted); max-width: 440px; margin: 0 auto; line-height: 1.7; }                                                                                                     
                                                                                                                                                                                                               
  footer {                                                                                                                                                                                                     
    border-top: 1px solid var(--border);                                                                                                                                                                       
    padding: 32px 0;                                                                                                                                                                                           
    display: flex; justify-content: space-between; align-items: center;
    flex-wrap: wrap; gap: 12px;                                                                                                                                                                                
  }                                                                                                                                                                                                            
  .footer-dot { width: 6px; height: 6px; border-radius: 50%; background: var(--dim); }
  .footer-text { font-size: 12px; color: var(--dim); }                                                                                                                                                         
                  
  #success { display: none; min-height: 100vh; flex-direction: column; justify-content: center; padding: 120px 0 80px; }                                                                                       
  #success.visible { display: flex; }
                                                                                                                                                                                                               
  .success-eyebrow {                                                                                                                                                                                           
    font-size: 11px; letter-spacing: .2em;
    text-transform: uppercase; color: var(--accent);                                                                                                                                                           
    margin-bottom: 32px;
    display: flex; align-items: center; gap: 10px;
  }                                                                                                                                                                                                            
  .success-eyebrow::before { content: ''; display: block; width: 24px; height: 1px; background: var(--accent); }
                                                                                                                                                                                                               
  .success-head { font-size: clamp(32px, 6vw, 56px); font-weight: 300; letter-spacing: -.025em; line-height: 1.1; margin-bottom: 16px; }                                                                       
  .success-sub { font-size: 16px; color: var(--muted); margin-bottom: 52px; font-weight: 300; line-height: 1.65; }
                                                                                                                                                                                                               
  .position-badge {
    display: inline-flex; align-items: center; gap: 12px;                                                                                                                                                      
    background: var(--s1); border: 1px solid var(--border2);                                                                                                                                                   
    border-radius: 12px; padding: 14px 20px;
    margin-bottom: 40px;                                                                                                                                                                                       
  }               
  .position-num { font-size: 22px; font-weight: 300; color: var(--accent2); letter-spacing: -.02em; }                                                                                                          
  .position-lbl { font-size: 12px; color: var(--muted); }                                                                                                                                                      
                                                                                                                                                                                                               
  .ref-box { background: var(--s1); border: 1px solid var(--border); border-radius: 14px; padding: 28px; margin-bottom: 32px; }                                                                                
  .ref-box-head { font-size: 13px; font-weight: 500; color: var(--text); margin-bottom: 6px; }                                                                                                                 
  .ref-box-sub { font-size: 13px; color: var(--muted); margin-bottom: 20px; }                                                                                                                                  
  .ref-link-row { display: flex; gap: 8px; align-items: center; }
  .ref-link-input {                                                                                                                                                                                            
    flex: 1; background: var(--bg);
    border: 1px solid var(--border); border-radius: 8px;                                                                                                                                                       
    padding: 10px 14px; font-size: 13px;
    color: var(--muted); font-family: 'SF Mono', 'Fira Code', monospace;                                                                                                                                       
    outline: none; cursor: default;
    overflow: hidden; text-overflow: ellipsis; white-space: nowrap;                                                                                                                                            
  }               
  .copy-btn {                                                                                                                                                                                                  
    background: none; border: 1px solid var(--border2);                                                                                                                                                        
    border-radius: 8px; padding: 10px 16px;
    font-size: 12px; font-weight: 500;                                                                                                                                                                         
    color: var(--text); cursor: pointer;
    transition: all .2s; white-space: nowrap;                                                                                                                                                                  
    font-family: inherit;                                                                                                                                                                                      
  }
  .copy-btn:hover { background: var(--border); border-color: var(--accent); }                                                                                                                                  
  .copy-btn.copied { color: var(--accent); border-color: var(--accent); }
                                                                                                                                                                                                               
  .share-row { display: flex; gap: 8px; margin-top: 16px; flex-wrap: wrap; }                                                                                                                                   
  .share-btn {                                                                                                                                                                                                 
    display: flex; align-items: center; gap: 7px;                                                                                                                                                              
    background: none; border: 1px solid var(--border);
    border-radius: 8px; padding: 8px 14px;                                                                                                                                                                     
    font-size: 12px; color: var(--muted);
    cursor: pointer; transition: all .15s;                                                                                                                                                                     
    font-family: inherit; text-decoration: none;
  }                                                                                                                                                                                                            
  .share-btn:hover { border-color: var(--border2); color: var(--text); }
                                                                                                                                                                                                               
  .tiers { margin-top: 8px; }                                                                                                                                                                                  
  .tier-label { font-size: 11px; letter-spacing: .14em; text-transform: uppercase; color: var(--dim); margin-bottom: 16px; }                                                                                   
  .tier { display: flex; align-items: center; gap: 14px; padding: 14px 0; border-bottom: 1px solid var(--border); transition: opacity .2s; }                                                                   
  .tier:last-child { border-bottom: none; }                                                                                                                                                                    
  .tier.locked { opacity: .4; }                                                                                                                                                                                
  .tier-icon {                                                                                                                                                                                                 
    width: 28px; height: 28px; border-radius: 50%;
    display: flex; align-items: center; justify-content: center;                                                                                                                                               
    font-size: 13px; flex-shrink: 0;
    border: 1px solid var(--border); background: var(--bg); color: var(--dim);                                                                                                                                 
  }                                                                                                                                                                                                            
  .tier.active .tier-icon { background: rgba(201,122,78,.15); border-color: var(--accent); color: var(--accent); }                                                                                             
  .tier.done .tier-icon { background: rgba(90,154,106,.15); border-color: #5a9a6a; color: #5a9a6a; }                                                                                                           
  .tier-body { flex: 1; }                                                                                                                                                                                      
  .tier-name { font-size: 14px; font-weight: 500; color: var(--text); }                                                                                                                                        
  .tier.locked .tier-name { color: var(--muted); font-weight: 400; }                                                                                                                                           
  .tier-desc { font-size: 12px; color: var(--dim); margin-top: 2px; }                                                                                                                                          
  .tier-req {                                                                                                                                                                                                  
    font-size: 11px; color: var(--dim);
    background: var(--s1); border: 1px solid var(--border);                                                                                                                                                    
    border-radius: 20px; padding: 3px 10px; white-space: nowrap;                                                                                                                                               
  }                                                                                                                                                                                                            
  .tier.active .tier-req { color: var(--accent); border-color: var(--border2); }                                                                                                                               
                                                                                                                                                                                                               
  .back-btn {     
    background: none; border: 1px solid var(--border2);                                                                                                                                                        
    border-radius: 8px; padding: 10px 20px;
    font-size: 13px; color: var(--muted);                                                                                                                                                                      
    cursor: pointer; font-family: inherit;
    transition: all .2s;                                                                                                                                                                                       
  }               
  .back-btn:hover { border-color: var(--accent); color: var(--text); }                                                                                                                                         
   
  @keyframes fadeUp {                                                                                                                                                                                          
    from { opacity: 0; transform: translateY(16px); }
    to   { opacity: 1; transform: translateY(0); }                                                                                                                                                             
  }               
  .fade-up    { animation: fadeUp .6s ease forwards; }
  .fade-up-d1 { animation: fadeUp .6s .1s ease both; }                                                                                                                                                         
  .fade-up-d2 { animation: fadeUp .6s .2s ease both; }                                                                                                                                                         
  .fade-up-d3 { animation: fadeUp .6s .3s ease both; }                                                                                                                                                         
  .fade-up-d4 { animation: fadeUp .6s .4s ease both; }                                                                                                                                                         
  .fade-up-d5 { animation: fadeUp .6s .5s ease both; }
                                                                                                                                                                                                               
  @media (max-width: 520px) {                                                                                                                                                                                  
    header { padding: 20px; }
    .form-wrap { flex-direction: column; }                                                                                                                                                                     
    .form-wrap input[type="email"] { min-width: 0; }
    .btn { width: 100%; text-align: center; }                                                                                                                                                                  
    .mystery { padding: 32px 24px; }
    .ref-box { padding: 20px; }                                                                                                                                                                                
    .position-badge { margin-bottom: 28px; }
    footer { flex-direction: column; align-items: flex-start; }                                                                                                                                                
  }               

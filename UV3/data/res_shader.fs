uniform float uv_fade;
uniform float uv_alpha;

in vec2 texcoord;

out vec4 fragColor;

void main(void)
{	
	float rad = length(texcoord);
	
		//make a circle
		if (rad > 1.){
			discard;
		}

	fragColor = vec4(1.,1.,0.,1.);

	fragColor.a *=  uv_fade * uv_alpha;
		
}

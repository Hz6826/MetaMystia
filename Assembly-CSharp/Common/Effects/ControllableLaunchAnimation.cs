using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using UnityEngine;

namespace Common.Effects
{
	// Token: 0x0200034A RID: 842
	public class ControllableLaunchAnimation : MonoBehaviour
	{
		// Token: 0x060063F8 RID: 25592 RVA: 0x001EC6D4 File Offset: 0x001EA8D4
		// Note: this type is marked as 'beforefieldinit'.
		static ControllableLaunchAnimation()
		{
			Il2CppClassPointerStore<ControllableLaunchAnimation>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Common.Effects", "ControllableLaunchAnimation");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ControllableLaunchAnimation>.NativeClassPtr);
			ControllableLaunchAnimation.NativeFieldInfoPtr_launchHeight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControllableLaunchAnimation>.NativeClassPtr, "launchHeight");
			ControllableLaunchAnimation.NativeFieldInfoPtr_launchSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControllableLaunchAnimation>.NativeClassPtr, "launchSpeed");
			ControllableLaunchAnimation.NativeFieldInfoPtr_launchWeight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControllableLaunchAnimation>.NativeClassPtr, "launchWeight");
			ControllableLaunchAnimation.NativeFieldInfoPtr_distance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControllableLaunchAnimation>.NativeClassPtr, "distance");
			ControllableLaunchAnimation.NativeFieldInfoPtr_effect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControllableLaunchAnimation>.NativeClassPtr, "effect");
			ControllableLaunchAnimation.NativeFieldInfoPtr_start = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControllableLaunchAnimation>.NativeClassPtr, "start");
			ControllableLaunchAnimation.NativeFieldInfoPtr_control = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControllableLaunchAnimation>.NativeClassPtr, "control");
			ControllableLaunchAnimation.NativeFieldInfoPtr_dest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControllableLaunchAnimation>.NativeClassPtr, "dest");
			ControllableLaunchAnimation.NativeMethodInfoPtr_OnDestroy_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllableLaunchAnimation>.NativeClassPtr, 100684255);
			ControllableLaunchAnimation.NativeMethodInfoPtr_Initialize_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllableLaunchAnimation>.NativeClassPtr, 100684256);
			ControllableLaunchAnimation.NativeMethodInfoPtr_Setup_Public_IEnumerator_Vector3_Vector3_Sprite_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllableLaunchAnimation>.NativeClassPtr, 100684257);
			ControllableLaunchAnimation.NativeMethodInfoPtr_OnLaunch_Private_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllableLaunchAnimation>.NativeClassPtr, 100684258);
			ControllableLaunchAnimation.NativeMethodInfoPtr_SolveBezierLocation_Private_Vector3_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllableLaunchAnimation>.NativeClassPtr, 100684259);
			ControllableLaunchAnimation.NativeMethodInfoPtr_SolveLaunchSpeed_Private_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllableLaunchAnimation>.NativeClassPtr, 100684260);
			ControllableLaunchAnimation.NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllableLaunchAnimation>.NativeClassPtr, 100684261);
			ControllableLaunchAnimation.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllableLaunchAnimation>.NativeClassPtr, 100684262);
		}

		// Token: 0x060063F9 RID: 25593 RVA: 0x001EC844 File Offset: 0x001EAA44
		[CallerCount(0)]
		public unsafe void OnDestroy()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControllableLaunchAnimation.NativeMethodInfoPtr_OnDestroy_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060063FA RID: 25594 RVA: 0x001EC878 File Offset: 0x001EAA78
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 257614, RefRangeEnd = 257615, XrefRangeStart = 257610, XrefRangeEnd = 257614, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Initialize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControllableLaunchAnimation.NativeMethodInfoPtr_Initialize_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060063FB RID: 25595 RVA: 0x001EC8AC File Offset: 0x001EAAAC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 257621, RefRangeEnd = 257622, XrefRangeStart = 257615, XrefRangeEnd = 257621, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator Setup(Vector3 startPosition, Vector3 launchDestination, Sprite targetSprite)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref startPosition;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref launchDestination;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(targetSprite);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControllableLaunchAnimation.NativeMethodInfoPtr_Setup_Public_IEnumerator_Vector3_Vector3_Sprite_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x060063FC RID: 25596 RVA: 0x001EC918 File Offset: 0x001EAB18
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 257622, XrefRangeEnd = 257627, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator OnLaunch()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControllableLaunchAnimation.NativeMethodInfoPtr_OnLaunch_Private_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x060063FD RID: 25597 RVA: 0x001EC958 File Offset: 0x001EAB58
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 257628, RefRangeEnd = 257629, XrefRangeStart = 257627, XrefRangeEnd = 257628, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Vector3 SolveBezierLocation(float t)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref t;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControllableLaunchAnimation.NativeMethodInfoPtr_SolveBezierLocation_Private_Vector3_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060063FE RID: 25598 RVA: 0x001EC9A4 File Offset: 0x001EABA4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 257629, XrefRangeEnd = 257630, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe float SolveLaunchSpeed(float t)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref t;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControllableLaunchAnimation.NativeMethodInfoPtr_SolveLaunchSpeed_Private_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060063FF RID: 25599 RVA: 0x001EC9F0 File Offset: 0x001EABF0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Cleanup_Generated()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ControllableLaunchAnimation.NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006400 RID: 25600 RVA: 0x001ECA2C File Offset: 0x001EAC2C
		[CallerCount(197)]
		[CachedScanResults(RefRangeStart = 190, RefRangeEnd = 387, XrefRangeStart = 190, XrefRangeEnd = 387, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ControllableLaunchAnimation() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ControllableLaunchAnimation>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControllableLaunchAnimation.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006401 RID: 25601 RVA: 0x0003615B File Offset: 0x0003435B
		public ControllableLaunchAnimation(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002272 RID: 8818
		// (get) Token: 0x06006402 RID: 25602 RVA: 0x001ECA68 File Offset: 0x001EAC68
		// (set) Token: 0x06006403 RID: 25603 RVA: 0x00036164 File Offset: 0x00034364
		public unsafe float launchHeight
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControllableLaunchAnimation.NativeFieldInfoPtr_launchHeight);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControllableLaunchAnimation.NativeFieldInfoPtr_launchHeight)) = value;
			}
		}

		// Token: 0x17002273 RID: 8819
		// (get) Token: 0x06006404 RID: 25604 RVA: 0x001ECA90 File Offset: 0x001EAC90
		// (set) Token: 0x06006405 RID: 25605 RVA: 0x0003617F File Offset: 0x0003437F
		public unsafe float launchSpeed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControllableLaunchAnimation.NativeFieldInfoPtr_launchSpeed);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControllableLaunchAnimation.NativeFieldInfoPtr_launchSpeed)) = value;
			}
		}

		// Token: 0x17002274 RID: 8820
		// (get) Token: 0x06006406 RID: 25606 RVA: 0x001ECAB8 File Offset: 0x001EACB8
		// (set) Token: 0x06006407 RID: 25607 RVA: 0x0003619A File Offset: 0x0003439A
		public unsafe float launchWeight
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControllableLaunchAnimation.NativeFieldInfoPtr_launchWeight);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControllableLaunchAnimation.NativeFieldInfoPtr_launchWeight)) = value;
			}
		}

		// Token: 0x17002275 RID: 8821
		// (get) Token: 0x06006408 RID: 25608 RVA: 0x001ECAE0 File Offset: 0x001EACE0
		// (set) Token: 0x06006409 RID: 25609 RVA: 0x000361B5 File Offset: 0x000343B5
		public unsafe float distance
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControllableLaunchAnimation.NativeFieldInfoPtr_distance);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControllableLaunchAnimation.NativeFieldInfoPtr_distance)) = value;
			}
		}

		// Token: 0x17002276 RID: 8822
		// (get) Token: 0x0600640A RID: 25610 RVA: 0x001ECB08 File Offset: 0x001EAD08
		// (set) Token: 0x0600640B RID: 25611 RVA: 0x000361D0 File Offset: 0x000343D0
		public unsafe ParticleSystem effect
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControllableLaunchAnimation.NativeFieldInfoPtr_effect);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ParticleSystem>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControllableLaunchAnimation.NativeFieldInfoPtr_effect), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002277 RID: 8823
		// (get) Token: 0x0600640C RID: 25612 RVA: 0x001ECB38 File Offset: 0x001EAD38
		// (set) Token: 0x0600640D RID: 25613 RVA: 0x000361EF File Offset: 0x000343EF
		public unsafe Vector3 start
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControllableLaunchAnimation.NativeFieldInfoPtr_start);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControllableLaunchAnimation.NativeFieldInfoPtr_start)) = value;
			}
		}

		// Token: 0x17002278 RID: 8824
		// (get) Token: 0x0600640E RID: 25614 RVA: 0x001ECB60 File Offset: 0x001EAD60
		// (set) Token: 0x0600640F RID: 25615 RVA: 0x0003620A File Offset: 0x0003440A
		public unsafe Vector3 control
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControllableLaunchAnimation.NativeFieldInfoPtr_control);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControllableLaunchAnimation.NativeFieldInfoPtr_control)) = value;
			}
		}

		// Token: 0x17002279 RID: 8825
		// (get) Token: 0x06006410 RID: 25616 RVA: 0x001ECB88 File Offset: 0x001EAD88
		// (set) Token: 0x06006411 RID: 25617 RVA: 0x00036225 File Offset: 0x00034425
		public unsafe Vector3 dest
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControllableLaunchAnimation.NativeFieldInfoPtr_dest);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControllableLaunchAnimation.NativeFieldInfoPtr_dest)) = value;
			}
		}

		// Token: 0x0400424D RID: 16973
		private static readonly IntPtr NativeFieldInfoPtr_launchHeight;

		// Token: 0x0400424E RID: 16974
		private static readonly IntPtr NativeFieldInfoPtr_launchSpeed;

		// Token: 0x0400424F RID: 16975
		private static readonly IntPtr NativeFieldInfoPtr_launchWeight;

		// Token: 0x04004250 RID: 16976
		private static readonly IntPtr NativeFieldInfoPtr_distance;

		// Token: 0x04004251 RID: 16977
		private static readonly IntPtr NativeFieldInfoPtr_effect;

		// Token: 0x04004252 RID: 16978
		private static readonly IntPtr NativeFieldInfoPtr_start;

		// Token: 0x04004253 RID: 16979
		private static readonly IntPtr NativeFieldInfoPtr_control;

		// Token: 0x04004254 RID: 16980
		private static readonly IntPtr NativeFieldInfoPtr_dest;

		// Token: 0x04004255 RID: 16981
		private static readonly IntPtr NativeMethodInfoPtr_OnDestroy_Private_Void_0;

		// Token: 0x04004256 RID: 16982
		private static readonly IntPtr NativeMethodInfoPtr_Initialize_Public_Void_0;

		// Token: 0x04004257 RID: 16983
		private static readonly IntPtr NativeMethodInfoPtr_Setup_Public_IEnumerator_Vector3_Vector3_Sprite_0;

		// Token: 0x04004258 RID: 16984
		private static readonly IntPtr NativeMethodInfoPtr_OnLaunch_Private_IEnumerator_0;

		// Token: 0x04004259 RID: 16985
		private static readonly IntPtr NativeMethodInfoPtr_SolveBezierLocation_Private_Vector3_Single_0;

		// Token: 0x0400425A RID: 16986
		private static readonly IntPtr NativeMethodInfoPtr_SolveLaunchSpeed_Private_Single_Single_0;

		// Token: 0x0400425B RID: 16987
		private static readonly IntPtr NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_New_Void_0;

		// Token: 0x0400425C RID: 16988
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000E03 RID: 3587
		[ObfuscatedName("Common.Effects.ControllableLaunchAnimation+<Setup>d__10")]
		public sealed class _Setup_d__10 : Il2CppSystem.Object
		{
			// Token: 0x060102C2 RID: 66242 RVA: 0x003C54C4 File Offset: 0x003C36C4
			// Note: this type is marked as 'beforefieldinit'.
			static _Setup_d__10()
			{
				Il2CppClassPointerStore<ControllableLaunchAnimation._Setup_d__10>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ControllableLaunchAnimation>.NativeClassPtr, "<Setup>d__10");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ControllableLaunchAnimation._Setup_d__10>.NativeClassPtr);
				ControllableLaunchAnimation._Setup_d__10.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControllableLaunchAnimation._Setup_d__10>.NativeClassPtr, "<>1__state");
				ControllableLaunchAnimation._Setup_d__10.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControllableLaunchAnimation._Setup_d__10>.NativeClassPtr, "<>2__current");
				ControllableLaunchAnimation._Setup_d__10.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControllableLaunchAnimation._Setup_d__10>.NativeClassPtr, "<>4__this");
				ControllableLaunchAnimation._Setup_d__10.NativeFieldInfoPtr_startPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControllableLaunchAnimation._Setup_d__10>.NativeClassPtr, "startPosition");
				ControllableLaunchAnimation._Setup_d__10.NativeFieldInfoPtr_launchDestination = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControllableLaunchAnimation._Setup_d__10>.NativeClassPtr, "launchDestination");
				ControllableLaunchAnimation._Setup_d__10.NativeFieldInfoPtr_targetSprite = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControllableLaunchAnimation._Setup_d__10>.NativeClassPtr, "targetSprite");
				ControllableLaunchAnimation._Setup_d__10.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllableLaunchAnimation._Setup_d__10>.NativeClassPtr, 100684263);
				ControllableLaunchAnimation._Setup_d__10.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllableLaunchAnimation._Setup_d__10>.NativeClassPtr, 100684264);
				ControllableLaunchAnimation._Setup_d__10.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllableLaunchAnimation._Setup_d__10>.NativeClassPtr, 100684265);
				ControllableLaunchAnimation._Setup_d__10.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllableLaunchAnimation._Setup_d__10>.NativeClassPtr, 100684266);
				ControllableLaunchAnimation._Setup_d__10.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllableLaunchAnimation._Setup_d__10>.NativeClassPtr, 100684267);
				ControllableLaunchAnimation._Setup_d__10.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllableLaunchAnimation._Setup_d__10>.NativeClassPtr, 100684268);
			}

			// Token: 0x060102C3 RID: 66243 RVA: 0x003C55E0 File Offset: 0x003C37E0
			[CallerCount(94)]
			[CachedScanResults(RefRangeStart = 3957, RefRangeEnd = 4051, XrefRangeStart = 3957, XrefRangeEnd = 4051, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _Setup_d__10(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ControllableLaunchAnimation._Setup_d__10>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref <>1__state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControllableLaunchAnimation._Setup_d__10.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060102C4 RID: 66244 RVA: 0x003C5628 File Offset: 0x003C3828
			[CallerCount(13496)]
			[CachedScanResults(RefRangeStart = 4051, RefRangeEnd = 17547, XrefRangeStart = 4051, XrefRangeEnd = 17547, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControllableLaunchAnimation._Setup_d__10.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060102C5 RID: 66245 RVA: 0x003C565C File Offset: 0x003C385C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 257576, XrefRangeEnd = 257591, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControllableLaunchAnimation._Setup_d__10.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17005494 RID: 21652
			// (get) Token: 0x060102C6 RID: 66246 RVA: 0x003C5698 File Offset: 0x003C3898
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControllableLaunchAnimation._Setup_d__10.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x060102C7 RID: 66247 RVA: 0x003C56D8 File Offset: 0x003C38D8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 257591, XrefRangeEnd = 257597, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControllableLaunchAnimation._Setup_d__10.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17005495 RID: 21653
			// (get) Token: 0x060102C8 RID: 66248 RVA: 0x003C570C File Offset: 0x003C390C
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControllableLaunchAnimation._Setup_d__10.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x060102C9 RID: 66249 RVA: 0x0008CC14 File Offset: 0x0008AE14
			public _Setup_d__10(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x1700548E RID: 21646
			// (get) Token: 0x060102CA RID: 66250 RVA: 0x003C574C File Offset: 0x003C394C
			// (set) Token: 0x060102CB RID: 66251 RVA: 0x0008CC1D File Offset: 0x0008AE1D
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControllableLaunchAnimation._Setup_d__10.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControllableLaunchAnimation._Setup_d__10.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x1700548F RID: 21647
			// (get) Token: 0x060102CC RID: 66252 RVA: 0x003C5774 File Offset: 0x003C3974
			// (set) Token: 0x060102CD RID: 66253 RVA: 0x0008CC38 File Offset: 0x0008AE38
			public unsafe Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControllableLaunchAnimation._Setup_d__10.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControllableLaunchAnimation._Setup_d__10.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17005490 RID: 21648
			// (get) Token: 0x060102CE RID: 66254 RVA: 0x003C57A4 File Offset: 0x003C39A4
			// (set) Token: 0x060102CF RID: 66255 RVA: 0x0008CC57 File Offset: 0x0008AE57
			public unsafe ControllableLaunchAnimation __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControllableLaunchAnimation._Setup_d__10.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ControllableLaunchAnimation>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControllableLaunchAnimation._Setup_d__10.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17005491 RID: 21649
			// (get) Token: 0x060102D0 RID: 66256 RVA: 0x003C57D4 File Offset: 0x003C39D4
			// (set) Token: 0x060102D1 RID: 66257 RVA: 0x0008CC76 File Offset: 0x0008AE76
			public unsafe Vector3 startPosition
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControllableLaunchAnimation._Setup_d__10.NativeFieldInfoPtr_startPosition);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControllableLaunchAnimation._Setup_d__10.NativeFieldInfoPtr_startPosition)) = value;
				}
			}

			// Token: 0x17005492 RID: 21650
			// (get) Token: 0x060102D2 RID: 66258 RVA: 0x003C57FC File Offset: 0x003C39FC
			// (set) Token: 0x060102D3 RID: 66259 RVA: 0x0008CC91 File Offset: 0x0008AE91
			public unsafe Vector3 launchDestination
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControllableLaunchAnimation._Setup_d__10.NativeFieldInfoPtr_launchDestination);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControllableLaunchAnimation._Setup_d__10.NativeFieldInfoPtr_launchDestination)) = value;
				}
			}

			// Token: 0x17005493 RID: 21651
			// (get) Token: 0x060102D4 RID: 66260 RVA: 0x003C5824 File Offset: 0x003C3A24
			// (set) Token: 0x060102D5 RID: 66261 RVA: 0x0008CCAC File Offset: 0x0008AEAC
			public unsafe Sprite targetSprite
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControllableLaunchAnimation._Setup_d__10.NativeFieldInfoPtr_targetSprite);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Sprite>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControllableLaunchAnimation._Setup_d__10.NativeFieldInfoPtr_targetSprite), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400A421 RID: 42017
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x0400A422 RID: 42018
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x0400A423 RID: 42019
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x0400A424 RID: 42020
			private static readonly IntPtr NativeFieldInfoPtr_startPosition;

			// Token: 0x0400A425 RID: 42021
			private static readonly IntPtr NativeFieldInfoPtr_launchDestination;

			// Token: 0x0400A426 RID: 42022
			private static readonly IntPtr NativeFieldInfoPtr_targetSprite;

			// Token: 0x0400A427 RID: 42023
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x0400A428 RID: 42024
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400A429 RID: 42025
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x0400A42A RID: 42026
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x0400A42B RID: 42027
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400A42C RID: 42028
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}

		// Token: 0x02000E04 RID: 3588
		[ObfuscatedName("Common.Effects.ControllableLaunchAnimation+<OnLaunch>d__11")]
		public sealed class _OnLaunch_d__11 : Il2CppSystem.Object
		{
			// Token: 0x060102D6 RID: 66262 RVA: 0x003C5854 File Offset: 0x003C3A54
			// Note: this type is marked as 'beforefieldinit'.
			static _OnLaunch_d__11()
			{
				Il2CppClassPointerStore<ControllableLaunchAnimation._OnLaunch_d__11>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ControllableLaunchAnimation>.NativeClassPtr, "<OnLaunch>d__11");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ControllableLaunchAnimation._OnLaunch_d__11>.NativeClassPtr);
				ControllableLaunchAnimation._OnLaunch_d__11.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControllableLaunchAnimation._OnLaunch_d__11>.NativeClassPtr, "<>1__state");
				ControllableLaunchAnimation._OnLaunch_d__11.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControllableLaunchAnimation._OnLaunch_d__11>.NativeClassPtr, "<>2__current");
				ControllableLaunchAnimation._OnLaunch_d__11.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControllableLaunchAnimation._OnLaunch_d__11>.NativeClassPtr, "<>4__this");
				ControllableLaunchAnimation._OnLaunch_d__11.NativeFieldInfoPtr__progress_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControllableLaunchAnimation._OnLaunch_d__11>.NativeClassPtr, "<progress>5__2");
				ControllableLaunchAnimation._OnLaunch_d__11.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllableLaunchAnimation._OnLaunch_d__11>.NativeClassPtr, 100684269);
				ControllableLaunchAnimation._OnLaunch_d__11.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllableLaunchAnimation._OnLaunch_d__11>.NativeClassPtr, 100684270);
				ControllableLaunchAnimation._OnLaunch_d__11.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllableLaunchAnimation._OnLaunch_d__11>.NativeClassPtr, 100684271);
				ControllableLaunchAnimation._OnLaunch_d__11.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllableLaunchAnimation._OnLaunch_d__11>.NativeClassPtr, 100684272);
				ControllableLaunchAnimation._OnLaunch_d__11.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllableLaunchAnimation._OnLaunch_d__11>.NativeClassPtr, 100684273);
				ControllableLaunchAnimation._OnLaunch_d__11.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllableLaunchAnimation._OnLaunch_d__11>.NativeClassPtr, 100684274);
			}

			// Token: 0x060102D7 RID: 66263 RVA: 0x003C5948 File Offset: 0x003C3B48
			[CallerCount(94)]
			[CachedScanResults(RefRangeStart = 3957, RefRangeEnd = 4051, XrefRangeStart = 3957, XrefRangeEnd = 4051, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _OnLaunch_d__11(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ControllableLaunchAnimation._OnLaunch_d__11>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref <>1__state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControllableLaunchAnimation._OnLaunch_d__11.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060102D8 RID: 66264 RVA: 0x003C5990 File Offset: 0x003C3B90
			[CallerCount(13496)]
			[CachedScanResults(RefRangeStart = 4051, RefRangeEnd = 17547, XrefRangeStart = 4051, XrefRangeEnd = 17547, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControllableLaunchAnimation._OnLaunch_d__11.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060102D9 RID: 66265 RVA: 0x003C59C4 File Offset: 0x003C3BC4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 257597, XrefRangeEnd = 257604, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControllableLaunchAnimation._OnLaunch_d__11.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x1700549A RID: 21658
			// (get) Token: 0x060102DA RID: 66266 RVA: 0x003C5A00 File Offset: 0x003C3C00
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControllableLaunchAnimation._OnLaunch_d__11.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x060102DB RID: 66267 RVA: 0x003C5A40 File Offset: 0x003C3C40
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 257604, XrefRangeEnd = 257610, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControllableLaunchAnimation._OnLaunch_d__11.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x1700549B RID: 21659
			// (get) Token: 0x060102DC RID: 66268 RVA: 0x003C5A74 File Offset: 0x003C3C74
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControllableLaunchAnimation._OnLaunch_d__11.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x060102DD RID: 66269 RVA: 0x0008CCCB File Offset: 0x0008AECB
			public _OnLaunch_d__11(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17005496 RID: 21654
			// (get) Token: 0x060102DE RID: 66270 RVA: 0x003C5AB4 File Offset: 0x003C3CB4
			// (set) Token: 0x060102DF RID: 66271 RVA: 0x0008CCD4 File Offset: 0x0008AED4
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControllableLaunchAnimation._OnLaunch_d__11.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControllableLaunchAnimation._OnLaunch_d__11.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17005497 RID: 21655
			// (get) Token: 0x060102E0 RID: 66272 RVA: 0x003C5ADC File Offset: 0x003C3CDC
			// (set) Token: 0x060102E1 RID: 66273 RVA: 0x0008CCEF File Offset: 0x0008AEEF
			public unsafe Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControllableLaunchAnimation._OnLaunch_d__11.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControllableLaunchAnimation._OnLaunch_d__11.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17005498 RID: 21656
			// (get) Token: 0x060102E2 RID: 66274 RVA: 0x003C5B0C File Offset: 0x003C3D0C
			// (set) Token: 0x060102E3 RID: 66275 RVA: 0x0008CD0E File Offset: 0x0008AF0E
			public unsafe ControllableLaunchAnimation __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControllableLaunchAnimation._OnLaunch_d__11.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ControllableLaunchAnimation>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControllableLaunchAnimation._OnLaunch_d__11.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17005499 RID: 21657
			// (get) Token: 0x060102E4 RID: 66276 RVA: 0x003C5B3C File Offset: 0x003C3D3C
			// (set) Token: 0x060102E5 RID: 66277 RVA: 0x0008CD2D File Offset: 0x0008AF2D
			public unsafe float _progress_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControllableLaunchAnimation._OnLaunch_d__11.NativeFieldInfoPtr__progress_5__2);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControllableLaunchAnimation._OnLaunch_d__11.NativeFieldInfoPtr__progress_5__2)) = value;
				}
			}

			// Token: 0x0400A42D RID: 42029
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x0400A42E RID: 42030
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x0400A42F RID: 42031
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x0400A430 RID: 42032
			private static readonly IntPtr NativeFieldInfoPtr__progress_5__2;

			// Token: 0x0400A431 RID: 42033
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x0400A432 RID: 42034
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400A433 RID: 42035
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x0400A434 RID: 42036
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x0400A435 RID: 42037
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400A436 RID: 42038
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}

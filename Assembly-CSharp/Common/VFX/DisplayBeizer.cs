using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace Common.VFX
{
	// Token: 0x0200034B RID: 843
	public class DisplayBeizer : MonoBehaviour
	{
		// Token: 0x06006412 RID: 25618 RVA: 0x001ECBB0 File Offset: 0x001EADB0
		// Note: this type is marked as 'beforefieldinit'.
		static DisplayBeizer()
		{
			Il2CppClassPointerStore<DisplayBeizer>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Common.VFX", "DisplayBeizer");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DisplayBeizer>.NativeClassPtr);
			DisplayBeizer.NativeFieldInfoPtr_start = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DisplayBeizer>.NativeClassPtr, "start");
			DisplayBeizer.NativeFieldInfoPtr_target = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DisplayBeizer>.NativeClassPtr, "target");
			DisplayBeizer.NativeFieldInfoPtr_trail = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DisplayBeizer>.NativeClassPtr, "trail");
			DisplayBeizer.NativeFieldInfoPtr_height = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DisplayBeizer>.NativeClassPtr, "height");
			DisplayBeizer.NativeFieldInfoPtr_steps = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DisplayBeizer>.NativeClassPtr, "steps");
			DisplayBeizer.NativeFieldInfoPtr_maxSteps = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DisplayBeizer>.NativeClassPtr, "maxSteps");
			DisplayBeizer.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DisplayBeizer>.NativeClassPtr, 100684275);
			DisplayBeizer.NativeMethodInfoPtr_OnDestroy_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DisplayBeizer>.NativeClassPtr, 100684276);
			DisplayBeizer.NativeMethodInfoPtr_SolveBezierLocation_Public_Static_Vector3_Vector3_Vector3_Vector3_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DisplayBeizer>.NativeClassPtr, 100684277);
			DisplayBeizer.NativeMethodInfoPtr_SolveBezierLocationCubic_Public_Static_Vector3_Vector3_Vector3_Vector3_Vector3_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DisplayBeizer>.NativeClassPtr, 100684278);
			DisplayBeizer.NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DisplayBeizer>.NativeClassPtr, 100684279);
			DisplayBeizer.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DisplayBeizer>.NativeClassPtr, 100684280);
			DisplayBeizer.NativeMethodInfoPtr__Update_b__6_0_Private_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DisplayBeizer>.NativeClassPtr, 100684281);
		}

		// Token: 0x06006413 RID: 25619 RVA: 0x001ECCE4 File Offset: 0x001EAEE4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 257630, XrefRangeEnd = 257683, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DisplayBeizer.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006414 RID: 25620 RVA: 0x001ECD18 File Offset: 0x001EAF18
		[CallerCount(0)]
		public unsafe void OnDestroy()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DisplayBeizer.NativeMethodInfoPtr_OnDestroy_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006415 RID: 25621 RVA: 0x001ECD4C File Offset: 0x001EAF4C
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 257689, RefRangeEnd = 257695, XrefRangeStart = 257683, XrefRangeEnd = 257689, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Vector3 SolveBezierLocation(Vector3 start, Vector3 control, Vector3 target, float t)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref start;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref control;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref target;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref t;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DisplayBeizer.NativeMethodInfoPtr_SolveBezierLocation_Public_Static_Vector3_Vector3_Vector3_Vector3_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06006416 RID: 25622 RVA: 0x001ECDB4 File Offset: 0x001EAFB4
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 257698, RefRangeEnd = 257702, XrefRangeStart = 257695, XrefRangeEnd = 257698, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Vector3 SolveBezierLocationCubic(Vector3 start, Vector3 control1, Vector3 control2, Vector3 target, float t)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref start;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref control1;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref control2;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref target;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref t;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DisplayBeizer.NativeMethodInfoPtr_SolveBezierLocationCubic_Public_Static_Vector3_Vector3_Vector3_Vector3_Vector3_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06006417 RID: 25623 RVA: 0x001ECE2C File Offset: 0x001EB02C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Cleanup_Generated()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DisplayBeizer.NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006418 RID: 25624 RVA: 0x001ECE68 File Offset: 0x001EB068
		[CallerCount(197)]
		[CachedScanResults(RefRangeStart = 190, RefRangeEnd = 387, XrefRangeStart = 190, XrefRangeEnd = 387, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DisplayBeizer() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DisplayBeizer>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DisplayBeizer.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006419 RID: 25625 RVA: 0x001ECEA4 File Offset: 0x001EB0A4
		[CallerCount(0)]
		public unsafe float _Update_b__6_0(float y)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref y;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DisplayBeizer.NativeMethodInfoPtr__Update_b__6_0_Private_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600641A RID: 25626 RVA: 0x00036240 File Offset: 0x00034440
		public DisplayBeizer(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700227A RID: 8826
		// (get) Token: 0x0600641B RID: 25627 RVA: 0x001ECEF0 File Offset: 0x001EB0F0
		// (set) Token: 0x0600641C RID: 25628 RVA: 0x00036249 File Offset: 0x00034449
		public unsafe Transform start
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DisplayBeizer.NativeFieldInfoPtr_start);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DisplayBeizer.NativeFieldInfoPtr_start), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700227B RID: 8827
		// (get) Token: 0x0600641D RID: 25629 RVA: 0x001ECF20 File Offset: 0x001EB120
		// (set) Token: 0x0600641E RID: 25630 RVA: 0x00036268 File Offset: 0x00034468
		public unsafe Transform target
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DisplayBeizer.NativeFieldInfoPtr_target);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DisplayBeizer.NativeFieldInfoPtr_target), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700227C RID: 8828
		// (get) Token: 0x0600641F RID: 25631 RVA: 0x001ECF50 File Offset: 0x001EB150
		// (set) Token: 0x06006420 RID: 25632 RVA: 0x00036287 File Offset: 0x00034487
		public unsafe LineRenderer trail
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DisplayBeizer.NativeFieldInfoPtr_trail);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<LineRenderer>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DisplayBeizer.NativeFieldInfoPtr_trail), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700227D RID: 8829
		// (get) Token: 0x06006421 RID: 25633 RVA: 0x001ECF80 File Offset: 0x001EB180
		// (set) Token: 0x06006422 RID: 25634 RVA: 0x000362A6 File Offset: 0x000344A6
		public unsafe float height
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DisplayBeizer.NativeFieldInfoPtr_height);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DisplayBeizer.NativeFieldInfoPtr_height)) = value;
			}
		}

		// Token: 0x1700227E RID: 8830
		// (get) Token: 0x06006423 RID: 25635 RVA: 0x001ECFA8 File Offset: 0x001EB1A8
		// (set) Token: 0x06006424 RID: 25636 RVA: 0x000362C1 File Offset: 0x000344C1
		public unsafe int steps
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DisplayBeizer.NativeFieldInfoPtr_steps);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DisplayBeizer.NativeFieldInfoPtr_steps)) = value;
			}
		}

		// Token: 0x1700227F RID: 8831
		// (get) Token: 0x06006425 RID: 25637 RVA: 0x001ECFD0 File Offset: 0x001EB1D0
		// (set) Token: 0x06006426 RID: 25638 RVA: 0x000362DC File Offset: 0x000344DC
		public unsafe float maxSteps
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DisplayBeizer.NativeFieldInfoPtr_maxSteps);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DisplayBeizer.NativeFieldInfoPtr_maxSteps)) = value;
			}
		}

		// Token: 0x0400425D RID: 16989
		private static readonly IntPtr NativeFieldInfoPtr_start;

		// Token: 0x0400425E RID: 16990
		private static readonly IntPtr NativeFieldInfoPtr_target;

		// Token: 0x0400425F RID: 16991
		private static readonly IntPtr NativeFieldInfoPtr_trail;

		// Token: 0x04004260 RID: 16992
		private static readonly IntPtr NativeFieldInfoPtr_height;

		// Token: 0x04004261 RID: 16993
		private static readonly IntPtr NativeFieldInfoPtr_steps;

		// Token: 0x04004262 RID: 16994
		private static readonly IntPtr NativeFieldInfoPtr_maxSteps;

		// Token: 0x04004263 RID: 16995
		private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

		// Token: 0x04004264 RID: 16996
		private static readonly IntPtr NativeMethodInfoPtr_OnDestroy_Private_Void_0;

		// Token: 0x04004265 RID: 16997
		private static readonly IntPtr NativeMethodInfoPtr_SolveBezierLocation_Public_Static_Vector3_Vector3_Vector3_Vector3_Single_0;

		// Token: 0x04004266 RID: 16998
		private static readonly IntPtr NativeMethodInfoPtr_SolveBezierLocationCubic_Public_Static_Vector3_Vector3_Vector3_Vector3_Vector3_Single_0;

		// Token: 0x04004267 RID: 16999
		private static readonly IntPtr NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_New_Void_0;

		// Token: 0x04004268 RID: 17000
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04004269 RID: 17001
		private static readonly IntPtr NativeMethodInfoPtr__Update_b__6_0_Private_Single_Single_0;
	}
}

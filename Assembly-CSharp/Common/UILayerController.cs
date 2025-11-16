using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine;

namespace Common
{
	// Token: 0x02000339 RID: 825
	public class UILayerController : MonoBehaviour
	{
		// Token: 0x06006270 RID: 25200 RVA: 0x001E77E0 File Offset: 0x001E59E0
		// Note: this type is marked as 'beforefieldinit'.
		static UILayerController()
		{
			Il2CppClassPointerStore<UILayerController>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Common", "UILayerController");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UILayerController>.NativeClassPtr);
			UILayerController.NativeFieldInfoPtr_set = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UILayerController>.NativeClassPtr, "set");
			UILayerController.NativeMethodInfoPtr_OnValidate_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UILayerController>.NativeClassPtr, 100684024);
			UILayerController.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UILayerController>.NativeClassPtr, 100684025);
		}

		// Token: 0x06006271 RID: 25201 RVA: 0x001E784C File Offset: 0x001E5A4C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 255003, XrefRangeEnd = 255063, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnValidate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UILayerController.NativeMethodInfoPtr_OnValidate_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006272 RID: 25202 RVA: 0x001E7880 File Offset: 0x001E5A80
		[CallerCount(197)]
		[CachedScanResults(RefRangeStart = 190, RefRangeEnd = 387, XrefRangeStart = 190, XrefRangeEnd = 387, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe UILayerController() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UILayerController>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UILayerController.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006273 RID: 25203 RVA: 0x00035350 File Offset: 0x00033550
		public UILayerController(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170021E0 RID: 8672
		// (get) Token: 0x06006274 RID: 25204 RVA: 0x001E78BC File Offset: 0x001E5ABC
		// (set) Token: 0x06006275 RID: 25205 RVA: 0x00035359 File Offset: 0x00033559
		public unsafe bool set
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UILayerController.NativeFieldInfoPtr_set);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UILayerController.NativeFieldInfoPtr_set)) = value;
			}
		}

		// Token: 0x04004142 RID: 16706
		private static readonly IntPtr NativeFieldInfoPtr_set;

		// Token: 0x04004143 RID: 16707
		private static readonly IntPtr NativeMethodInfoPtr_OnValidate_Private_Void_0;

		// Token: 0x04004144 RID: 16708
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000DEF RID: 3567
		[ObfuscatedName("Common.UILayerController+<>c")]
		[Serializable]
		public sealed class __c : Il2CppSystem.Object
		{
			// Token: 0x06010148 RID: 65864 RVA: 0x003C10FC File Offset: 0x003BF2FC
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<UILayerController.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<UILayerController>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UILayerController.__c>.NativeClassPtr);
				UILayerController.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UILayerController.__c>.NativeClassPtr, "<>9");
				UILayerController.__c.NativeFieldInfoPtr___9__1_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UILayerController.__c>.NativeClassPtr, "<>9__1_0");
				UILayerController.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UILayerController.__c>.NativeClassPtr, 100684027);
				UILayerController.__c.NativeMethodInfoPtr__OnValidate_b__1_0_Internal_Single_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UILayerController.__c>.NativeClassPtr, 100684028);
			}

			// Token: 0x06010149 RID: 65865 RVA: 0x003C1178 File Offset: 0x003BF378
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UILayerController.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UILayerController.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0601014A RID: 65866 RVA: 0x003C11B4 File Offset: 0x003BF3B4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 255002, XrefRangeEnd = 255003, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe float _OnValidate_b__1_0(Transform x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UILayerController.__c.NativeMethodInfoPtr__OnValidate_b__1_0_Internal_Single_Transform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0601014B RID: 65867 RVA: 0x0008BD53 File Offset: 0x00089F53
			public __c(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x1700540C RID: 21516
			// (get) Token: 0x0601014C RID: 65868 RVA: 0x003C1204 File Offset: 0x003BF404
			// (set) Token: 0x0601014D RID: 65869 RVA: 0x0008BD5C File Offset: 0x00089F5C
			public unsafe static UILayerController.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(UILayerController.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<UILayerController.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(UILayerController.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700540D RID: 21517
			// (get) Token: 0x0601014E RID: 65870 RVA: 0x003C122C File Offset: 0x003BF42C
			// (set) Token: 0x0601014F RID: 65871 RVA: 0x0008BD6E File Offset: 0x00089F6E
			public unsafe static Func<Transform, float> __9__1_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(UILayerController.__c.NativeFieldInfoPtr___9__1_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Transform, float>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(UILayerController.__c.NativeFieldInfoPtr___9__1_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400A340 RID: 41792
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x0400A341 RID: 41793
			private static readonly IntPtr NativeFieldInfoPtr___9__1_0;

			// Token: 0x0400A342 RID: 41794
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400A343 RID: 41795
			private static readonly IntPtr NativeMethodInfoPtr__OnValidate_b__1_0_Internal_Single_Transform_0;
		}
	}
}

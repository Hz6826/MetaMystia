using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using UnityEngine;
using UnityEngine.Playables;

namespace NightScene.TimelineExtestion
{
	// Token: 0x02000215 RID: 533
	public class NS_Set_DoTimeFlow : PlayableAsset
	{
		// Token: 0x06003DBF RID: 15807 RVA: 0x0016FBE8 File Offset: 0x0016DDE8
		// Note: this type is marked as 'beforefieldinit'.
		static NS_Set_DoTimeFlow()
		{
			Il2CppClassPointerStore<NS_Set_DoTimeFlow>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "NightScene.TimelineExtestion", "NS_Set_DoTimeFlow");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NS_Set_DoTimeFlow>.NativeClassPtr);
			NS_Set_DoTimeFlow.NativeFieldInfoPtr_shouldFlow = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NS_Set_DoTimeFlow>.NativeClassPtr, "shouldFlow");
			NS_Set_DoTimeFlow.NativeMethodInfoPtr_CreatePlayable_Public_Virtual_Playable_PlayableGraph_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NS_Set_DoTimeFlow>.NativeClassPtr, 100674596);
			NS_Set_DoTimeFlow.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NS_Set_DoTimeFlow>.NativeClassPtr, 100674597);
		}

		// Token: 0x06003DC0 RID: 15808 RVA: 0x0016FC54 File Offset: 0x0016DE54
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 137392, XrefRangeEnd = 137404, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Playable CreatePlayable(PlayableGraph graph, GameObject owner)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref graph;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(owner);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NS_Set_DoTimeFlow.NativeMethodInfoPtr_CreatePlayable_Public_Virtual_Playable_PlayableGraph_GameObject_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06003DC1 RID: 15809 RVA: 0x0016FCBC File Offset: 0x0016DEBC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 40720, RefRangeEnd = 40722, XrefRangeStart = 40720, XrefRangeEnd = 40722, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe NS_Set_DoTimeFlow() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NS_Set_DoTimeFlow>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NS_Set_DoTimeFlow.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003DC2 RID: 15810 RVA: 0x00022809 File Offset: 0x00020A09
		public NS_Set_DoTimeFlow(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700150E RID: 5390
		// (get) Token: 0x06003DC3 RID: 15811 RVA: 0x0016FCF8 File Offset: 0x0016DEF8
		// (set) Token: 0x06003DC4 RID: 15812 RVA: 0x00022812 File Offset: 0x00020A12
		public unsafe bool shouldFlow
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NS_Set_DoTimeFlow.NativeFieldInfoPtr_shouldFlow);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NS_Set_DoTimeFlow.NativeFieldInfoPtr_shouldFlow)) = value;
			}
		}

		// Token: 0x04002934 RID: 10548
		private static readonly IntPtr NativeFieldInfoPtr_shouldFlow;

		// Token: 0x04002935 RID: 10549
		private static readonly IntPtr NativeMethodInfoPtr_CreatePlayable_Public_Virtual_Playable_PlayableGraph_GameObject_0;

		// Token: 0x04002936 RID: 10550
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}

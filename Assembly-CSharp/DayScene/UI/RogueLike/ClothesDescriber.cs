using System;
using GameData.Core.Collections;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Threading;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace DayScene.UI.RogueLike
{
	// Token: 0x020000FA RID: 250
	public class ClothesDescriber : MonoBehaviour
	{
		// Token: 0x06001B7F RID: 7039 RVA: 0x000FACFC File Offset: 0x000F8EFC
		// Note: this type is marked as 'beforefieldinit'.
		static ClothesDescriber()
		{
			Il2CppClassPointerStore<ClothesDescriber>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "DayScene.UI.RogueLike", "ClothesDescriber");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ClothesDescriber>.NativeClassPtr);
			ClothesDescriber.NativeFieldInfoPtr_m_Portrayal = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClothesDescriber>.NativeClassPtr, "m_Portrayal");
			ClothesDescriber.NativeFieldInfoPtr_m_Text = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClothesDescriber>.NativeClassPtr, "m_Text");
			ClothesDescriber.NativeMethodInfoPtr_Describe_Public_Virtual_Final_New_Void_Item_CancellationToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClothesDescriber>.NativeClassPtr, 100668283);
			ClothesDescriber.NativeMethodInfoPtr_DescribeNull_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClothesDescriber>.NativeClassPtr, 100668284);
			ClothesDescriber.NativeMethodInfoPtr_OnDestroy_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClothesDescriber>.NativeClassPtr, 100668285);
			ClothesDescriber.NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClothesDescriber>.NativeClassPtr, 100668286);
			ClothesDescriber.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClothesDescriber>.NativeClassPtr, 100668287);
		}

		// Token: 0x06001B80 RID: 7040 RVA: 0x000FADB8 File Offset: 0x000F8FB8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 72517, XrefRangeEnd = 72529, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Describe(Item data, CancellationToken cancellationToken)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(data);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(cancellationToken));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ClothesDescriber.NativeMethodInfoPtr_Describe_Public_Virtual_Final_New_Void_Item_CancellationToken_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001B81 RID: 7041 RVA: 0x000FAE14 File Offset: 0x000F9014
		[CallerCount(13496)]
		[CachedScanResults(RefRangeStart = 4051, RefRangeEnd = 17547, XrefRangeStart = 4051, XrefRangeEnd = 17547, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void DescribeNull()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ClothesDescriber.NativeMethodInfoPtr_DescribeNull_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001B82 RID: 7042 RVA: 0x000FAE48 File Offset: 0x000F9048
		[CallerCount(11)]
		[CachedScanResults(RefRangeStart = 27675, RefRangeEnd = 27686, XrefRangeStart = 27675, XrefRangeEnd = 27686, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnDestroy()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ClothesDescriber.NativeMethodInfoPtr_OnDestroy_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001B83 RID: 7043 RVA: 0x000FAE7C File Offset: 0x000F907C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Cleanup_Generated()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ClothesDescriber.NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001B84 RID: 7044 RVA: 0x000FAEB8 File Offset: 0x000F90B8
		[CallerCount(197)]
		[CachedScanResults(RefRangeStart = 190, RefRangeEnd = 387, XrefRangeStart = 190, XrefRangeEnd = 387, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ClothesDescriber() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ClothesDescriber>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ClothesDescriber.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001B85 RID: 7045 RVA: 0x00010C1F File Offset: 0x0000EE1F
		public ClothesDescriber(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170008C7 RID: 2247
		// (get) Token: 0x06001B86 RID: 7046 RVA: 0x000FAEF4 File Offset: 0x000F90F4
		// (set) Token: 0x06001B87 RID: 7047 RVA: 0x00010C28 File Offset: 0x0000EE28
		public unsafe Image m_Portrayal
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClothesDescriber.NativeFieldInfoPtr_m_Portrayal);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Image>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClothesDescriber.NativeFieldInfoPtr_m_Portrayal), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170008C8 RID: 2248
		// (get) Token: 0x06001B88 RID: 7048 RVA: 0x000FAF24 File Offset: 0x000F9124
		// (set) Token: 0x06001B89 RID: 7049 RVA: 0x00010C47 File Offset: 0x0000EE47
		public unsafe TextMeshProUGUI m_Text
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClothesDescriber.NativeFieldInfoPtr_m_Text);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClothesDescriber.NativeFieldInfoPtr_m_Text), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400124F RID: 4687
		private static readonly IntPtr NativeFieldInfoPtr_m_Portrayal;

		// Token: 0x04001250 RID: 4688
		private static readonly IntPtr NativeFieldInfoPtr_m_Text;

		// Token: 0x04001251 RID: 4689
		private static readonly IntPtr NativeMethodInfoPtr_Describe_Public_Virtual_Final_New_Void_Item_CancellationToken_0;

		// Token: 0x04001252 RID: 4690
		private static readonly IntPtr NativeMethodInfoPtr_DescribeNull_Public_Virtual_Final_New_Void_0;

		// Token: 0x04001253 RID: 4691
		private static readonly IntPtr NativeMethodInfoPtr_OnDestroy_Private_Void_0;

		// Token: 0x04001254 RID: 4692
		private static readonly IntPtr NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_New_Void_0;

		// Token: 0x04001255 RID: 4693
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}

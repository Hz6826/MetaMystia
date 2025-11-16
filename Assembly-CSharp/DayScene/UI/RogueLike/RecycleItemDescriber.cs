using System;
using Common.UI;
using GameData.Core.Collections;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Threading;
using TMPro;

namespace DayScene.UI.RogueLike
{
	// Token: 0x0200012F RID: 303
	public class RecycleItemDescriber : ObjectLanguageBaseDescriber
	{
		// Token: 0x0600236F RID: 9071 RVA: 0x001148F0 File Offset: 0x00112AF0
		// Note: this type is marked as 'beforefieldinit'.
		static RecycleItemDescriber()
		{
			Il2CppClassPointerStore<RecycleItemDescriber>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "DayScene.UI.RogueLike", "RecycleItemDescriber");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RecycleItemDescriber>.NativeClassPtr);
			RecycleItemDescriber.NativeFieldInfoPtr_m_recyclePriceText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RecycleItemDescriber>.NativeClassPtr, "m_recyclePriceText");
			RecycleItemDescriber.NativeFieldInfoPtr_WASHI_ID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RecycleItemDescriber>.NativeClassPtr, "WASHI_ID");
			RecycleItemDescriber.NativeFieldInfoPtr_CANDY_ID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RecycleItemDescriber>.NativeClassPtr, "CANDY_ID");
			RecycleItemDescriber.NativeMethodInfoPtr_Describe_Public_Virtual_Final_New_Void_RecycleItem_CancellationToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RecycleItemDescriber>.NativeClassPtr, 100669580);
			RecycleItemDescriber.NativeMethodInfoPtr_OnDescriberDestroyed_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RecycleItemDescriber>.NativeClassPtr, 100669581);
			RecycleItemDescriber.NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RecycleItemDescriber>.NativeClassPtr, 100669582);
			RecycleItemDescriber.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RecycleItemDescriber>.NativeClassPtr, 100669583);
		}

		// Token: 0x06002370 RID: 9072 RVA: 0x001149AC File Offset: 0x00112BAC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 83946, XrefRangeEnd = 83950, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Describe(RecycleItemDescriber.RecycleItem data, CancellationToken cancellationToken)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(data);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(cancellationToken));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RecycleItemDescriber.NativeMethodInfoPtr_Describe_Public_Virtual_Final_New_Void_RecycleItem_CancellationToken_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002371 RID: 9073 RVA: 0x00114A08 File Offset: 0x00112C08
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 83950, XrefRangeEnd = 83951, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnDescriberDestroyed()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RecycleItemDescriber.NativeMethodInfoPtr_OnDescriberDestroyed_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002372 RID: 9074 RVA: 0x00114A44 File Offset: 0x00112C44
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 83951, XrefRangeEnd = 83953, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Cleanup_Generated()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RecycleItemDescriber.NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002373 RID: 9075 RVA: 0x00114A80 File Offset: 0x00112C80
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 19188, RefRangeEnd = 19190, XrefRangeStart = 19188, XrefRangeEnd = 19190, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RecycleItemDescriber() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RecycleItemDescriber>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RecycleItemDescriber.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002374 RID: 9076 RVA: 0x000154B5 File Offset: 0x000136B5
		public RecycleItemDescriber(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000C34 RID: 3124
		// (get) Token: 0x06002375 RID: 9077 RVA: 0x00114ABC File Offset: 0x00112CBC
		// (set) Token: 0x06002376 RID: 9078 RVA: 0x000154BE File Offset: 0x000136BE
		public unsafe TextMeshProUGUI m_recyclePriceText
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RecycleItemDescriber.NativeFieldInfoPtr_m_recyclePriceText);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RecycleItemDescriber.NativeFieldInfoPtr_m_recyclePriceText), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000C35 RID: 3125
		// (get) Token: 0x06002377 RID: 9079 RVA: 0x00114AEC File Offset: 0x00112CEC
		// (set) Token: 0x06002378 RID: 9080 RVA: 0x000154DD File Offset: 0x000136DD
		public unsafe static int WASHI_ID
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(RecycleItemDescriber.NativeFieldInfoPtr_WASHI_ID, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RecycleItemDescriber.NativeFieldInfoPtr_WASHI_ID, (void*)(&value));
			}
		}

		// Token: 0x17000C36 RID: 3126
		// (get) Token: 0x06002379 RID: 9081 RVA: 0x00114B08 File Offset: 0x00112D08
		// (set) Token: 0x0600237A RID: 9082 RVA: 0x000154EB File Offset: 0x000136EB
		public unsafe static int CANDY_ID
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(RecycleItemDescriber.NativeFieldInfoPtr_CANDY_ID, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RecycleItemDescriber.NativeFieldInfoPtr_CANDY_ID, (void*)(&value));
			}
		}

		// Token: 0x0400179E RID: 6046
		private static readonly IntPtr NativeFieldInfoPtr_m_recyclePriceText;

		// Token: 0x0400179F RID: 6047
		private static readonly IntPtr NativeFieldInfoPtr_WASHI_ID;

		// Token: 0x040017A0 RID: 6048
		private static readonly IntPtr NativeFieldInfoPtr_CANDY_ID;

		// Token: 0x040017A1 RID: 6049
		private static readonly IntPtr NativeMethodInfoPtr_Describe_Public_Virtual_Final_New_Void_RecycleItem_CancellationToken_0;

		// Token: 0x040017A2 RID: 6050
		private static readonly IntPtr NativeMethodInfoPtr_OnDescriberDestroyed_Protected_Virtual_Void_0;

		// Token: 0x040017A3 RID: 6051
		private static readonly IntPtr NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_Void_0;

		// Token: 0x040017A4 RID: 6052
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000751 RID: 1873
		public class RecycleItem : Item
		{
			// Token: 0x06009F6F RID: 40815 RVA: 0x002A183C File Offset: 0x0029FA3C
			// Note: this type is marked as 'beforefieldinit'.
			static RecycleItem()
			{
				Il2CppClassPointerStore<RecycleItemDescriber.RecycleItem>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<RecycleItemDescriber>.NativeClassPtr, "RecycleItem");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RecycleItemDescriber.RecycleItem>.NativeClassPtr);
				RecycleItemDescriber.RecycleItem.NativeFieldInfoPtr_Price = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RecycleItemDescriber.RecycleItem>.NativeClassPtr, "Price");
				RecycleItemDescriber.RecycleItem.NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RecycleItemDescriber.RecycleItem>.NativeClassPtr, 100669584);
			}

			// Token: 0x06009F70 RID: 40816 RVA: 0x002A1890 File Offset: 0x0029FA90
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 83945, RefRangeEnd = 83946, XrefRangeStart = 83944, XrefRangeEnd = 83945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe RecycleItem(int id, int price) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RecycleItemDescriber.RecycleItem>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref id;
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref price;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RecycleItemDescriber.RecycleItem.NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06009F71 RID: 40817 RVA: 0x000562A6 File Offset: 0x000544A6
			public RecycleItem(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170034A7 RID: 13479
			// (get) Token: 0x06009F72 RID: 40818 RVA: 0x002A18E8 File Offset: 0x0029FAE8
			// (set) Token: 0x06009F73 RID: 40819 RVA: 0x000562AF File Offset: 0x000544AF
			public unsafe int Price
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RecycleItemDescriber.RecycleItem.NativeFieldInfoPtr_Price);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RecycleItemDescriber.RecycleItem.NativeFieldInfoPtr_Price)) = value;
				}
			}

			// Token: 0x04006762 RID: 26466
			private static readonly IntPtr NativeFieldInfoPtr_Price;

			// Token: 0x04006763 RID: 26467
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_0;
		}
	}
}
